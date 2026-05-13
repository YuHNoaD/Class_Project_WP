using System.Data;
using System.Data.SqlClient;

namespace UTEid.src.Services
{
    /// <summary>
    /// Manages connection to the local SQL Server database (loginDB.mdf).
    /// Provides low-level connection management and query execution.
    /// </summary>
    public class DatabaseService
    {
        private readonly SqlConnection _connection;

        public DatabaseService()
        {
            _connection = new SqlConnection(BuildConnectionString());
        }

        /// <summary>
        /// Locates the loginDB.mdf file by searching upward from the
        /// application's base directory until the file is found.
        /// </summary>
        private static string BuildConnectionString()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string databaseFileName = "loginDB.mdf";
            string databasePath = Path.Combine(currentDirectory, databaseFileName);

            // Walk up the directory tree until the .mdf file is found
            while (!File.Exists(databasePath) && Directory.GetParent(currentDirectory) != null)
            {
                currentDirectory = Directory.GetParent(currentDirectory)!.FullName;
                databasePath = Path.Combine(currentDirectory, databaseFileName);
            }

            if (!File.Exists(databasePath))
            {
                throw new FileNotFoundException(
                    "CRITICAL: Could not locate loginDB.mdf anywhere in the project directory tree."
                );
            }

            return $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{databasePath}"";Initial Catalog=loginDB;Integrated Security=True;Connect Timeout=30";
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Tests whether the database connection can be established.
        /// Shows a message box on failure.
        /// </summary>
        public bool TestConnection()
        {
            try
            {
                OpenConnection();
                CloseConnection();
                return true;
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database connection error: " + exception.Message,
                    "System Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
