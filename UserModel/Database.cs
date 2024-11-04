using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace UserModel
{
    public class User
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class DatabaseModel
    {
        private string connectionString = "Server=DESKTOP-G4EE8OT;Database=Nova;Trusted_Connection=True;";

        public void RegisterUser(string username, string password, UInt32 accountNumber)
        {
            byte[] passwordHash = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO dbo.UserLogs (Username, Password, AccountNumber) VALUES (@Username, @Password, @AccountNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);

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

        public bool CheckIfAccountNumberExist(UInt32 accountNumber)
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

        private byte[] HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
