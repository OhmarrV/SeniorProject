using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper 
    {
        private string connectionString = @"Data Source=C:\Users\omarv\OneDrive\Documents\Fall 24 Workspace\Senior Project git\10-29\SeniorProject\VelocifyUsers.db; Version=3"; //change to local path for Velocify db
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

        public bool SaveSessionToken(int userId, string token)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Reset current_token to 0 for all users
                        string resetQuery = "UPDATE UserInfo SET current_token = 0";
                        using (SQLiteCommand resetCmd = new SQLiteCommand(resetQuery, conn))
                        {
                            resetCmd.ExecuteNonQuery();
                        }

                        // Update session_token and set current_token to 1 for the specified user
                        string updateQuery = "UPDATE UserInfo SET session_token = @token, current_token = 1 WHERE id = @userId";
                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@token", token);
                            updateCmd.Parameters.AddWithValue("@userId", userId);
                            updateCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public string SearchSessionToken(int userId)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT session_token FROM UserInfo WHERE id = @userId AND current_token = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    object result = cmd.ExecuteScalar();

                    return result != null && result != DBNull.Value ? result.ToString() : null;
                }
            }
        }

        public int SearchActiveSessionToken()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT id FROM UserInfo WHERE current_token = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool ClearAllSessionTokens()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE UserInfo SET current_token = 0";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
