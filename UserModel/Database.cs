using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Encryption;

namespace UserModel
{
    public class User
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class DatabaseModel
    {
        private string connectionString = "Server=DESKTOP-G4EE8OT;Database=Nova;Trusted_Connection=True;TrustServerCertificate=True;";

        public void RegisterUser(string username, string password, int accountNumber, string dob)
        {
            // byte[] passwordHash = HashPassword(password);

            string encryptedPassword = EncryptSHA(password, "LxXgAZdO4sxwPo6rPkHsYwv1nl+2iUC2IgTIz9KCisI=\r\n");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO dbo.UserLogs (Username, Password, AccountNumber, DOB) VALUES (@Username, @Password, @AccountNumber, @DateBirth)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", encryptedPassword);
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@DateBirth", dob);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool CheckIfUserExist(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.UserLogs WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int userCount = (int)command.ExecuteScalar();

                    return userCount > 0;
                }
            }
        }

        public bool CheckIfAccountNumberExist(int accountNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.UserLogs WHERE AccountNumber = @AccountNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    int userCount = (int)command.ExecuteScalar();

                    return userCount > 0;
                }
            }
        }

        // Admin decode password system.

        private byte[] HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private string EncryptSHA(string text, string key)
        {
            string encryptedText = AESUtility.Encrypt(text, key);

            return encryptedText;
        }
    }
}
