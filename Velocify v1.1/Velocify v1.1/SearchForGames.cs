using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class SearchForGames : Form
    {
        private List<GameData> allGames;
        private Form1 _mainForm; // Declare a variable to hold the reference to Form1

        public SearchForGames(Form1 mainForm) // Accept Form1 as a parameter
        {
            InitializeComponent();
            _mainForm = mainForm; // Set the owner to the main form
            LoadAllGames();
            gamesListBox.SelectedIndexChanged += gamesListBox_SelectedIndexChanged; // Hook the event handler
        }

        private async void LoadAllGames()
        {
            allGames = await APIFile.GetAllGamesAsync(APIFile.ClientId, APIFile.AccessToken); // Use your constants or pass them directly
            UpdateListBox(allGames); // Call UpdateListBox with the fetched games
        }

        private async void UpdateListBox(List<GameData> allGames)
        {
            // Clear existing items
            gamesListBox.Items.Clear();

            foreach (var game in allGames)
            {
                if (game != null && !string.IsNullOrEmpty(game.name))
                {
                    // Add the GameData object itself to the list box
                    gamesListBox.Items.Add(game);
                }
                else
                {
                    // Handle null case
                    Console.WriteLine("Game or Game name is null");
                }
            }

            // Set DisplayMember here to ensure it's applied
            gamesListBox.DisplayMember = "name"; // Display the game name
        }

        private void gamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItem != null)
            {
                var selectedGame = (GameData)gamesListBox.SelectedItem;
                Console.WriteLine($"Selected game: {selectedGame.name}");

                // Ensure _mainForm is not null before accessing it
                if (_mainForm != null)
                {
                    _mainForm.DisplaySelectedGame(selectedGame);
                }
                else
                {
                    MessageBox.Show("Main form reference is null.");
                }
            }
        }
            private void SaveGameToDatabase(GameData selectedGame)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\lumen\\OneDrive\\Desktop\\SP2\\SeniorProject\\VelocifyUsers.db; Version=3"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Games (game_id, game_name, game_url) VALUES (@id, @name, @url)";
                    command.Parameters.AddWithValue("@id", selectedGame.id);
                    command.Parameters.AddWithValue("@name", selectedGame.name);
                    command.Parameters.AddWithValue("@url", selectedGame.coverUrl);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.ToLower();

            // Ensure you only call the API if there is input
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Split the search query to separate name and genre if necessary
                string[] searchTerms = searchQuery.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string nameQuery = searchTerms.Length > 0 ? searchTerms[0] : "";
                string genreQuery = searchTerms.Length > 1 ? searchTerms[1] : "";

                // Call the API with the name and genre
                var gamesByNameAndGenre = await APIFile.GetGamesByNameAndGenreAsync(nameQuery, genreQuery);

                // Clear the list box before adding new items
                gamesListBox.Items.Clear();

                if (gamesByNameAndGenre != null && gamesByNameAndGenre.Count > 0)
                {
                    foreach (var game in gamesByNameAndGenre)
                    {
                        gamesListBox.Items.Add(game); // Add GameData object directly
                    }
                }
                else
                {
                    gamesListBox.Items.Add("No games found.");
                }
            }
            else
            {
                gamesListBox.Items.Clear();
            }
        }
    }
}
