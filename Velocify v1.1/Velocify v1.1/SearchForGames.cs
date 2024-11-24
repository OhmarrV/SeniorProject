using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Velocify_v1._1
{
    public partial class SearchForGames : Form
    {

        private List<GameData> allGames;
        public string SelectedGameName { get; private set; }
        public string SelectedGameImg { get; private set; }
        public string SelectedGameId { get; private set; }

        private Form1 _mainForm;
        public SearchForGames()
        {
            InitializeComponent();
            LoadAllGames();

            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private async void LoadAllGames()
        {
            allGames = await APIFile.GetAllGamesAsync(APIFile.ClientId, APIFile.AccessToken); // Use your constants or pass them directly
            UpdateListBox(allGames); // Call UpdateListBox with the fetched games

            if(gamesListBox.Items.Count > 0)
            {
                gamesListBox.Items.Clear();
                gamesListBox.Items.Add("Search for games");
            }

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



        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItem is GameData selectedGame)
            {
                try
                {
                    SelectedGameName = selectedGame.name;
                    SelectedGameId = selectedGame.id.ToString();
                    SelectedGameImg = selectedGame.coverUrl;

                    // Testing Purposes
                    //MessageBox.Show(
                    //    $"Game Selected:\nName: {SelectedGameName}\nID: {SelectedGameId}\nCover: {SelectedGameImg}",
                    //    "Game Selected",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information
                    //);

                    DialogResult = DialogResult.OK; // Indicate successful selection
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a game from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim().ToLower(); // Trim and lowercase input

            if (string.IsNullOrEmpty(searchQuery))
            {
                // If the search box is empty, clear the list and show "Search for games"
                //MessageBox.Show("Please enter a game name to search.");
                gamesListBox.Items.Clear();
                gamesListBox.Items.Add("Search for games");
                return;
            }

            try
            {
                // Pass the search query directly to the IGDB API
                var gamesByName = await APIFile.GetGamesByNameAndGenreAsync(searchQuery);

                // Clear the list box before displaying new results
                gamesListBox.Items.Clear();

                if (gamesByName != null && gamesByName.Count > 0)
                {
                    foreach (var game in gamesByName)
                    {
                        gamesListBox.Items.Add(game); // Add GameData object directly
                    }
                }
                else
                {
                    gamesListBox.Items.Add("No games found...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching games: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string gameInfo(string NameOfGame)
        {
            string gameName = NameOfGame;
            return gameName;

        }

        
    }       
}
