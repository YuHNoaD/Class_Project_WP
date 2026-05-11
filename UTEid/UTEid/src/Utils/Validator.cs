using System.Text.RegularExpressions;

namespace UTEid.src.Utils
{
    /// <summary>
    /// Provides static validation helper methods for user input.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Checks if a string is null, empty, or whitespace.
        /// </summary>
        public static bool IsNotEmpty(string? value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Checks if all provided strings are non-empty.
        /// </summary>
        public static bool AreAllNotEmpty(params string?[] values)
        {
            foreach (var value in values)
            {
                if (string.IsNullOrWhiteSpace(value))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Validates email format using a simple regex pattern.
        /// </summary>
        public static bool IsValidEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// Checks if two passwords match.
        /// </summary>
        public static bool ArePasswordsMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        /// <summary>
        /// Validates that a password meets minimum requirements.
        /// (at least 6 characters)
        /// </summary>
        public static bool IsValidPassword(string? password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        }
    }
}
