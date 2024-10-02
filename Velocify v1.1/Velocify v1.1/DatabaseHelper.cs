using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=C:\Users\omarv\OneDrive\Documents\Fall 24 Workspace\Senior Project git\SeniorProject\VelocifyUsers.db; Version=3"; //change to local path for Velocify db
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
