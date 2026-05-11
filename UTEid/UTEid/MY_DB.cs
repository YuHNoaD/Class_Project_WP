using System;
using System.Data;
using System.Data.SqlClient;
using System.IO; // Thư viện bắt buộc để xử lý đường dẫn tệp tin
using BCrypt.Net;

public class MY_DB
{
    // Tạo chuỗi kết nối động dựa trên vị trí thực tế của file .mdf
    private static string GetConnectionString()
    {
        // 1. Lấy vị trí App đang chạy (Thường là trong bin\Debug\...)
        string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        string dbName = "loginDB.mdf";
        string dbPath = Path.Combine(currentDir, dbName);

        // 2. Thuật toán "Đi ngược dòng": 
        // Nếu không thấy file ở thư mục hiện tại, lùi dần ra ngoài cho đến khi thấy
        while (!File.Exists(dbPath) && Directory.GetParent(currentDir) != null)
        {
            // Nhảy ra thư mục cha
            currentDir = Directory.GetParent(currentDir).FullName;
            // Cập nhật lại đường dẫn file để vòng lặp sau kiểm tra
            dbPath = Path.Combine(currentDir, dbName);
        }

        // 3. Lớp phòng thủ cuối: Nếu quét sạch ổ cứng vẫn không thấy file đâu
        if (!File.Exists(dbPath))
        {
            throw new FileNotFoundException("Lỗi chí mạng: Không tìm thấy file loginDB.mdf ở bất kỳ đâu trong project!");
        }

        // 4. Trả về chuỗi kết nối chuẩn tuyệt đối
        return $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{dbPath}"";Initial Catalog=loginDB;Integrated Security=True;Connect Timeout=30";
    }

    // Khởi tạo SqlConnection bằng phương thức động
    private SqlConnection con = new SqlConnection(GetConnectionString());

    public SqlConnection getConnection() { return con; }

    public void openConnection()
    {
        if (con.State == ConnectionState.Closed) con.Open();
    }

    public void closeConnection()
    {
        if (con.State == ConnectionState.Open) con.Close();
    }

    // ==============================================================
    // HÀM KIỂM TRA KẾT NỐI (Dùng để chẩn đoán lỗi khi vừa bật App)
    // ==============================================================
    public bool TestConnection()
    {
        try
        {
            this.openConnection();
            this.closeConnection();
            return true;
        }
        catch (Exception ex)
        {
            // Hiển thị thông báo lỗi chi tiết nếu kết nối thất bại
            System.Windows.Forms.MessageBox.Show("Lỗi kết nối Database: " + ex.Message, "Hệ thống", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            return false;
        }
    }

    // ==========================================
    // 1. HÀM KIỂM TRA ĐĂNG NHẬP (Lõi Bảo mật)
    // ==========================================
    public bool VerifyUser(string username, string rawPassword)
    {
        SqlCommand command = new SqlCommand("SELECT password FROM log_in WHERE username=@User", this.getConnection());
        command.Parameters.AddWithValue("@User", username);

        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable table = new DataTable();
        adapter.Fill(table);

        if (table.Rows.Count == 1)
        {
            string storedHash = table.Rows[0]["password"].ToString();
            // Đối chiếu mật khẩu thô với mã băm trong Database
            return BCrypt.Net.BCrypt.Verify(rawPassword, storedHash);
        }
        return false;
    }

    // ==========================================
    // 2. HÀM TẠO TÀI KHOẢN MỚI BẢO MẬT
    // ==========================================
    public void CreateUser(string username, string email, string rawPassword)
    {
        // Băm mật khẩu
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(rawPassword);

        // Lệnh SQL mới với 3 tham số
        SqlCommand command = new SqlCommand("INSERT INTO log_in (username, email, password) VALUES (@User, @Email, @HashPass)", this.getConnection());
        command.Parameters.AddWithValue("@User", username);
        command.Parameters.AddWithValue("@Email", email);
        command.Parameters.AddWithValue("@HashPass", hashedPassword);

        this.openConnection();
        command.ExecuteNonQuery();
        this.closeConnection();
    }

    // ==========================================
    // 3. HÀM KIỂM TRA TRÙNG LẶP TÀI KHOẢN
    // ==========================================
    public bool CheckUserExists(string username)
    {
        SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username=@User", this.getConnection());
        command.Parameters.AddWithValue("@User", username);

        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable table = new DataTable();
        adapter.Fill(table);

        return table.Rows.Count > 0;
    }

    // Kiểm tra Email đã tồn tại chưa
    public bool CheckEmailExists(string email)
    {
        SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE email=@Email", this.getConnection());
        command.Parameters.AddWithValue("@Email", email);

        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable table = new DataTable();
        adapter.Fill(table);

        return table.Rows.Count > 0;
    }

    // ==========================================
    // 4. HÀM CẬP NHẬT MẬT KHẨU MỚI
    // ==========================================
    public bool UpdatePassword(string username, string newRawPassword)
    {
        // 1. Băm mật khẩu mới ra chuỗi 60 ký tự
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newRawPassword);

        // 2. Lệnh UPDATE để ghi đè mật khẩu của đúng user đó
        SqlCommand command = new SqlCommand("UPDATE log_in SET password=@HashPass WHERE username=@User", this.getConnection());
        command.Parameters.AddWithValue("@User", username);
        command.Parameters.AddWithValue("@HashPass", hashedPassword);

        this.openConnection();
        // ExecuteNonQuery trả về số dòng bị tác động trong SQL
        int rowsAffected = command.ExecuteNonQuery();
        this.closeConnection();

        // Nếu có ít nhất 1 dòng bị sửa, nghĩa là thành công
        return rowsAffected > 0;
    }
}