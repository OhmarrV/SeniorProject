using System;
using System.Data.SQLite;

namespace Velocify_v1._1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=C:\Users\omarv\OneDrive\Documents\Visual Studio 2022\Databases\VelocifyUsers.db; Version=3";
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
    }
}
