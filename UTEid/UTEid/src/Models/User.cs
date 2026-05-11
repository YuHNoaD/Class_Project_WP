namespace UTEid.src.Models
{
    /// <summary>
    /// Represents a user entity from the log_in table.
    /// </summary>
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public User() { }

        public User(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }

        public override string ToString()
        {
            return $"{Username} ({Email})";
        }
    }
}
