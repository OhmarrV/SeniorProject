using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=C:\Users\lumen\OneDrive\Desktop\SP\SeniorProject\VelocifyUsers.db; Version=3";
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

    }
}
