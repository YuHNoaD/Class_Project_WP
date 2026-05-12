using System.Data;
using System.Data.SqlClient;
using BCrypt.Net;

namespace UTEid.src.Services
{
    /// <summary>
    /// Handles user authentication operations including login verification,
    /// account creation, and password management.
    /// </summary>
    public class AuthService
    {
        private readonly DatabaseService _database;

        public AuthService()
        {
            _database = new DatabaseService();
        }

        public DatabaseService GetDatabase()
        {
            return _database;
        }

        /// <summary>
        /// Verifies user credentials by comparing the raw password
        /// against the BCrypt hash stored in the database.
        /// </summary>
        public bool VerifyUser(string username, string rawPassword)
        {
            var query = "SELECT password FROM Login WHERE username = @Username";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Username", username);

            _database.OpenConnection();
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            _database.CloseConnection();

            if (table.Rows.Count != 1)
                return false;

            string storedHash = table.Rows[0]["password"].ToString()!;
            return BCrypt.Net.BCrypt.Verify(rawPassword, storedHash);
        }

        /// <summary>
        /// Creates a new user account with a BCrypt-hashed password.
        /// </summary>
        public void CreateUser(string username, string email, string rawPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(rawPassword);

            var query = "INSERT INTO Login (username, email, password) VALUES (@Username, @Email, @PasswordHash)";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            _database.OpenConnection();
            command.ExecuteNonQuery();
            _database.CloseConnection();
        }

        /// <summary>
        /// Checks whether a username already exists in the database.
        /// </summary>
        public bool CheckUserExists(string username)
        {
            var query = "SELECT * FROM Login WHERE username = @Username";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Username", username);

            _database.OpenConnection();
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            _database.CloseConnection();

            return table.Rows.Count > 0;
        }

        /// <summary>
        /// Checks whether an email address is already registered.
        /// </summary>
        public bool CheckEmailExists(string email)
        {
            var query = "SELECT * FROM Login WHERE email = @Email";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Email", email);

            _database.OpenConnection();
            using var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            _database.CloseConnection();

            return table.Rows.Count > 0;
        }

        /// <summary>
        /// Updates the password for a given username with a new BCrypt hash.
        /// </summary>
        public bool UpdatePassword(string username, string newRawPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newRawPassword);

            var query = "UPDATE Login SET password = @PasswordHash WHERE username = @Username";
            using var command = new SqlCommand(query, _database.GetConnection());
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            _database.OpenConnection();
            int rowsAffected = command.ExecuteNonQuery();
            _database.CloseConnection();

            return rowsAffected > 0;
        }
    }
}



