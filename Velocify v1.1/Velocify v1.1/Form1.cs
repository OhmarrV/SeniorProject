using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class Form1 : Form
    {
        private List<string> userGames;
        private int userId;

        // Modify the constructor to accept user games and userId
        public Form1(List<string> games, int userId)
        {
            InitializeComponent();
            this.userGames = games;  // Store the list of games
            this.userId = userId;    // Store the current user's ID
        }

        // Load event for the form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the games as GamePanels when the form loads
            foreach (string gameName in userGames)
            {
                GameData gameData = new GameData { name = gameName, coverUrl = null };  // Create a GameData object (assuming you don't have a cover URL here)
                DisplaySelectedGame(gameData);  // Use the existing method to display the game
            }
        }

        public void DisplaySelectedGame(GameData selectedGame)
        {
            // Create an instance of GamePanel
            GamePanel gamePanel = new GamePanel();

            // Set the properties of the GamePanel
            gamePanel.labelGame.Text = selectedGame.name;  // Set the game name

            // Placeholder URL (local or online image)
            string placeholderUrl = "https://example.com/default_image.png";  // Replace this with your actual placeholder image URL

            // Ensure the coverUrl is a valid HTTP URL
            if (!string.IsNullOrEmpty(selectedGame.coverUrl))
            {
                string validCoverUrl = selectedGame.coverUrl.StartsWith("http://") || selectedGame.coverUrl.StartsWith("https://")
                    ? selectedGame.coverUrl
                    : "https://" + selectedGame.coverUrl.TrimStart('\\');  // Fix URL

                try
                {
                    gamePanel.pictureBox1.Load(validCoverUrl);  // Load the cover image
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                    gamePanel.pictureBox1.Load(placeholderUrl);  // Load default placeholder image
                }
            }
            else
            {
                gamePanel.pictureBox1.Load(placeholderUrl);  // Load default placeholder image
            }

            gamePanel.Size = new Size((int)(gamePanel.Width), (int)(gamePanel.Height));

            // Add the GamePanel to FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(gamePanel);
            gamePanel.BringToFront();  // Bring the new panel to the front
        }

        public void DisplayGamePanel(GamePanel gamePanel)
        {
            // Clear existing controls or manage panels as needed
            foreach (Control control in this.Controls)
            {
                if (control is GamePanel)
                {
                    this.Controls.Remove(control);
                    control.Dispose();  // Dispose of old panels if necessary
                }
            }

            // Add the new GamePanel to the Form
            this.Controls.Add(gamePanel);
            gamePanel.BringToFront();  // Bring the new panel to the front
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            // Pass 'this' (Form1) as a reference to the constructor of SearchForGames
            SearchForGames searchForm = new SearchForGames(this);
            searchForm.Show();  // Show the search form
            this.Hide();  // Optionally hide the main form while searching
        }

        private void gameAddButton1_Load(object sender, EventArgs e)
        {
            // You can add any logic here that you need for the gameAddButton1 control when it loads
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // You can add any logic here that you need for pictureBox2 control
        }
    }
}
