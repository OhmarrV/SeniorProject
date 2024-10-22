using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper 
    {
        private string connectionString = @"Data Source=C:\Users\jacom\Documents\2024 WorkSpace\SP Branches\10-22\SeniorProject\VelocifyUsers.db; Version=3"; //change to local path for Velocify db
                                                                                                                                                                           // Method to get a new SQLite connection
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Method to retrieve user information
        public SQLiteDataReader GetUserInfo()
        {
            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT * FROM UserInfo";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            return cmd.ExecuteReader();
        }

        // Method to check if a username already exists in the database
        public bool IsUsernameTaken(string username)
        {
            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT COUNT(1) FROM UserInfo WHERE username = @username";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            int userExists = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return userExists > 0; // Return true if username exists
        }

        // Method to create a new user in the database
        public bool CreateUser(string username, string password)
        {
            if (IsUsernameTaken(username))
            {
                return false; // Username already exists
            }

            // Hash the password before storing
            string hashedPassword = HashPassword(password);

            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO UserInfo (username, password) VALUES (@username, @password)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username.ToLower());
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                cmd.ExecuteNonQuery();
                return true; // User creation successful
            }
        }

        // Hash a password using SHA256
        public string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                var builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



        public SQLiteDataReader GameInfo()
        {
            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT * FROM Games";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            return cmd.ExecuteReader();
        }
    }
}
