using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

public class DatabaseHandler
{
    private SQLiteConnection connection;

    public DatabaseHandler(string databasePath)
    {
        // Properly escape the path by using double backslashes 
        Console.WriteLine($"Using database: C:\"C:\\Users\\jacom\\Documents\\2024 WorkSpace\\SP Branches\\FIXING BRANCH\\SeniorProject\\VelocifyUsers.db\".db");
        connection = new SQLiteConnection($"Data Source=\"C:\\Users\\jacom\\Documents\\2024 WorkSpace\\SP Branches\\FIXING BRANCH\\SeniorProject\\VelocifyUsers.db\";Version=3;");
        connection.Open();
    
        // Ensure tables are created
        CreateTables();
    }

    // Ensure the necessary tables exist
    private void CreateTables()
    {
        string createUserInfoTableQuery = @"
            CREATE TABLE IF NOT EXISTS UserInfo (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL,
                password TEXT NOT NULL
            );";

        using (SQLiteCommand cmd = new SQLiteCommand(createUserInfoTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }
    }

    // Hash password using SHA256
    public string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    // Add new user with hashed password
    public void AddUser(string username, string password)
    {
        string hashedPassword = HashPassword(password);  // Hash the password before storing
        Console.WriteLine($"Creating user: {username.ToLower()}, Hashed Password: {hashedPassword}");

        string query = "INSERT INTO UserInfo (username, password) VALUES (@username, @password)";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@username", username.ToLower());  // Store username in lowercase for consistency
            cmd.Parameters.AddWithValue("@password", hashedPassword);  // Store hashed password

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Rows affected: {rowsAffected}");  // Log how many rows were inserted
        }

        Console.WriteLine($"User {username.ToLower()} added successfully with hashed password.");
    }

    // Authenticate user by comparing hashed password
    public int? AuthenticateUser(string username, string password)
    {
        string hashedPassword = HashPassword(password);  // Hash the input password
        Console.WriteLine($"Login attempt: {username.ToLower()}, Hashed Password: {hashedPassword}");

        string query = "SELECT id, password FROM UserInfo WHERE LOWER(username) = @username";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@username", username.ToLower());

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string storedHashedPassword = reader["password"].ToString();
                    Console.WriteLine($"Stored hashed password: {storedHashedPassword}");

                    // Compare hashed passwords
                    if (storedHashedPassword == hashedPassword)
                    {
                        Console.WriteLine("User authenticated successfully.");
                        return Convert.ToInt32(reader["id"]);
                    }
                    else
                    {
                        Console.WriteLine("Password mismatch.");
                    }
                }
                else
                {
                    Console.WriteLine("Username not found.");
                }
            }
        }
        return null;
    }

    public void PrintAllUsers()
    {
        string query = "SELECT id, username FROM UserInfo";
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
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

    // Retrieve games associated with the user
    public List<string> GetUserGames(int userId)
    {
        string query = @"
            SELECT Games.game_name 
            FROM Games 
            JOIN UserGames ON Games.game_id = UserGames.game_id 
            WHERE UserGames.user_id = @userId";

        List<string> games = new List<string>();
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@userId", userId);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    games.Add(reader["game_name"].ToString());
                }
            }
        }
        return games;
    }
}
