using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=C:\Users\omarv\OneDrive\Documents\Fall 24 Workspace\Senior Project git\Lucas Branch\SeniorProject\VelocifyUsers.db; Version=3";
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public SQLiteDataReader GetUserInfo()
        {
            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT * FROM UserInfo";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            return cmd.ExecuteReader();

        }

        public SQLiteDataReader GameInfo()
        {
            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "SELECT * FROM Games";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            return cmd.ExecuteReader();
        }

        public void InsertGame(GameData game)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Games (game_id, game_name, game_url) VALUES (@id, @name, @url)";
                    command.Parameters.AddWithValue("@id", game.id);
                    command.Parameters.AddWithValue("@name", game.name);
                    command.Parameters.AddWithValue("@url", game.coverUrl);
                    command.ExecuteNonQuery();
                }
            }
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

            SQLiteConnection conn = GetConnection();
            conn.Open();

            string query = "INSERT INTO UserInfo (username, password) VALUES (@username, @password)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
            conn.Close();

            return true; // User creation successful
        }

    }
}
