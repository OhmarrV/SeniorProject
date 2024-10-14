using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=C:\SeniorProject\VelocifyUsers.db; Version=3";

        // Method to get the database connection
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Method to get all user info
        public SQLiteDataReader GetUserInfo()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM UserInfo";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                return cmd.ExecuteReader();
            }
        }

        // Method to get all game info
        public SQLiteDataReader GameInfo()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Games";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                return cmd.ExecuteReader();
            }
        }

        // Insert a new game into the database
        public void InsertGame(GameData game)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "INSERT INTO Games (game_id, game_name, game_url) VALUES (@id, @name, @url)";
                    command.Parameters.AddWithValue("@id", game.id);
                    command.Parameters.AddWithValue("@name", game.name);
                    command.Parameters.AddWithValue("@url", game.coverUrl ?? string.Empty);  // Handle possible null values
                    command.ExecuteNonQuery();
                }
            }
        }

        // Check if a username already exists in the database
        public bool IsUsernameTaken(string username)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM UserInfo WHERE LOWER(username) = @username";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username.ToLower());

                int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                return userExists > 0; // Return true if username exists
            }
        }

        // Create a new user in the database with hashed password
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

        // Print all existing users for debugging purposes
        public void PrintAllUsers()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT id, username FROM UserInfo";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Existing users in the database:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}, Username: {reader["username"]}");
                        }
                    }
                }
            }
        }
    }
}
