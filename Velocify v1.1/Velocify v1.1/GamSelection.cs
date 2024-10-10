using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class GameSelection : UserControl
    {
        public GameSelection()
        {
            InitializeComponent();  // This initializes gamesListBox from Designer.cs
            LoadGames();  // Loads game data into the ListBox
        }

        public void LoadGames()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            SQLiteDataReader reader = dbHelper.GameInfo();

            while (reader.Read())
            {
                string gameInfo = $"ID: {reader["game_id"]}, Name: {reader["game_name"]}, URL: {reader["game_url"]}";
                gamesListBox.Items.Add(gameInfo);  // Access gamesListBox initialized in Designer.cs
            }

            reader.Close();
        }
    }
}
