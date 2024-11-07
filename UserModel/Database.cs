using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Encryption;
using Microsoft.IdentityModel.Tokens;

namespace UserModel
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? AccountNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public static User? CurrentUser { get; set; }
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

        public bool Login(string username, string password)
        {
            if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return false;
            }

            string encryptedPassword = EncryptSHA(password, "LxXgAZdO4sxwPo6rPkHsYwv1nl+2iUC2IgTIz9KCisI=\r\n");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Password FROM dbo.UserLogs WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    string? dbPassword = (string?)command.ExecuteScalar();

                    if (dbPassword == null)
                    {
                        return false;
                    }

                    if (dbPassword == encryptedPassword)
                    {
                        return true;
                    }
                }
            }

            return false;
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

        public int ReturnAccountNumber(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AccountNumber FROM dbo.UserLogs WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int accountNumber = (int)command.ExecuteScalar();

                    return accountNumber;
                }
            }
        }

        public string ReturnDOB(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DOB FROM dbo.UserLogs WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    string dob = (string)command.ExecuteScalar();

                    return dob;
                }
            }
        }

        public void CreateTaskInput(string taskTitle, string dueDate, string priority, int taskId)
        {
            if (string.IsNullOrEmpty(taskTitle) || string.IsNullOrEmpty(dueDate)) {
                return;
            }

            if (User.CurrentUser == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(User.CurrentUser.Username))
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO dbo.ListData (ListTitle, UserId, DueDate, Priority, TaskId, Completed) VALUES (@ListTitle, @UserId, @DueDate, @Priority, @TaskId, 0)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ListTitle", taskTitle);
                    command.Parameters.AddWithValue("@UserId", ReturnAccountNumber(User.CurrentUser.Username));
                    command.Parameters.AddWithValue("@DueDate", dueDate);
                    command.Parameters.AddWithValue("@Priority", priority);
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void MarkTaskAsComplete(int taskId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE dbo.ListData SET Completed = 1, CompletedOn = @CompletedOn WHERE TaskId = @TaskId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    command.Parameters.AddWithValue("@CompletedOn", DateTime.Now.ToString("yyyy-MM-dd"));

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool CheckIfTaskIdExist(int taskId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM dbo.ListData WHERE TaskId = @TaskId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    int taskCount = (int)command.ExecuteScalar();

                    return taskCount > 0;
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
