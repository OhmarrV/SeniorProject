using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

public class DatabaseHandler
{
    private SQLiteConnection connection;

    public DatabaseHandler()
    {
        // Properly escape the path by using double backslashes 
        //Console.WriteLine($"Using database: C:\"C:\\Users\\jacom\\Documents\\2024 WorkSpace\\SP Branches\\new main\\SeniorProject\\VelocifyUsers.db\".db");
        connection = new SQLiteConnection($"Data Source=\"C:\\Users\\jacom\\Documents\\2024 WorkSpace\\SP Branches\\10-31\\SeniorProject\\VelocifyUsers.db\";Version=3;");
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
    public List<string> GetUserGameIds(int userId)
    {
        string query = @"
        SELECT game_id 
        FROM UserGames 
        WHERE user_id = @userId";

        List<string> gameIds = new List<string>();
        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@userId", userId);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    gameIds.Add(reader["game_id"].ToString());
                }
            }
        }
        return gameIds;
    }

    public void AddGameToUser(int userId, string gameId, string gameName)
    {
        string query = "INSERT INTO UserGames (user_id, game_id, game_name) VALUES (@userId, @gameId, @gameName)";

        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@gameId", gameId);
            cmd.Parameters.AddWithValue("@gameName", gameName);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Rows affected: {rowsAffected}"); // Logs how many rows were inserted
        }
    }


    public List<string> LoadUserGames(int userId)
    {
        List<string> gameIds = new List<string>();
        string query = "SELECT game_id FROM UserGames WHERE user_id = @userId";

        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@userId", userId);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    gameIds.Add(reader["game_id"].ToString());
                }
            }
        }

        return gameIds;
    }

    public void DeleteGameFromUser(int userId, string gameId)
    {
        // SQL query to delete the game from the user's library
        string query = "DELETE FROM UserGames WHERE user_id = @userId AND game_id = @gameId";

        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            // Bind the parameters
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@gameId", gameId);

            // Execute the command
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine($"Game {gameId} deleted for user {userId}");
            }
            else
            {
                Console.WriteLine($"Game {gameId} not found for user {userId}");
            }
        }
    }

    public string FindUserName(int userId)
    {
        // SQL query to find the username by ID
        string query = "SELECT username FROM UserInfo WHERE id = @userId";

        using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
        {
            // Bind the parameter
            cmd.Parameters.AddWithValue("@userId", userId);

            // Execute the command
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }

    }

    
}
