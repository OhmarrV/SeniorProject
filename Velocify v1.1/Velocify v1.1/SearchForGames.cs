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
        private Form1 _mainForm;
        public SearchForGames()
        {
            InitializeComponent();
            //_mainForm = mainForm;
            LoadAllGames();

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

        

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItem != null)
            {
                // Retrieve the selected item
                string selectedGame = gamesListBox.SelectedItem.ToString();
                


                // Split the string into parts based on ", " as the separator
                string[] gameDetails = selectedGame.Split(new string[] { ", " }, StringSplitOptions.None);
                MessageBox.Show(gameDetails[0]);

                // Now parse each part to extract the desired values NOT ADDING TO DB YET
                string gameName = gameDetails[0].Replace("Name: ", "").Trim();

                //string gameId = gameDetails[1].Replace("ID: ", "").Trim();


                // Show a message with the selected game details
                //MessageBox.Show("Game selected: " + gameName + " added to the list.");

                var gamesByNameAndGenre = await APIFile.GetGamesByNameAndGenreAsync(gameName);
                string IDgame = gamesByNameAndGenre[0].id.ToString();
                string gameData = await APIFile.GetGameByIdAsync(IDgame);

                //parse the gameData to get the cover URL
                JArray gameDataArray = JArray.Parse(gameData);

                // Access the first item in the array (if it exists)
                var gameDataimg = gameDataArray[0]; // First item in the array

                // Access the cover URL safely using ?. and Value<string>()
                string coverUrl = gameDataimg["cover"]?["url"]?.Value<string>() ?? "No URL";
                if (!string.IsNullOrEmpty(coverUrl))
                {
                    coverUrl = coverUrl.Replace("t_thumb", "t_cover_big");
                }

                MessageBox.Show(coverUrl);

                SelectedGameName = gameName;
                SelectedGameImg = coverUrl;

                //string gameImg = gameDetails[2].Replace("Cover URL: ", "").Trim();

                DialogResult = DialogResult.OK;
                
            }
            else
            {
                // No game was selected, show a message
                DialogResult = DialogResult.No;
                MessageBox.Show("Please select a game from the list.");
            }
            //MessageBox.Show("Game Added! ");
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
                //string IDgame = gamesByNameAndGenre[0].id.ToString();
                //MessageBox.Show(IDgame);

                //e.g., gamesByNameAndGenre[0].id will give you the id of the first game in the list

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

        
        public string gameInfo(string NameOfGame)
        {
            string gameName = NameOfGame;
            return gameName;

        }



    }
}
