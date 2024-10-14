using System;
using System.Data.SQLite;

public class UserAuthentication
{
	private SQLiteConnection connection;

	public UserAuthentication(string databasePath)
	{
		connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
		connection.Open();
	}

	public int? AuthenticateUser(string username, string password)
	{
		string query = "SELECT id FROM UserInfo WHERE username = @username AND password = @password";
		using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
		{
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@password", password);

			var result = cmd.ExecuteScalar();
			if (result != null)
			{
				return Convert.ToInt32(result);  // Return user ID if authenticated
			}
			else
			{
				return null;  // Authentication failed
			}
		}
	}
}
