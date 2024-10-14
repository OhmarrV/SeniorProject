namespace Velocify_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public void DisplaySelectedGame(GameData selectedGame)
        {
            // Create an instance of GamePanel
            GamePanel gamePanel = new GamePanel();

            // Set the properties of the GamePanel
            gamePanel.labelGame.Text = selectedGame.name; // Set the game name

            // Ensure the coverUrl is a valid HTTP URL
            if (!string.IsNullOrEmpty(selectedGame.coverUrl))
            {
                string validCoverUrl = selectedGame.coverUrl.StartsWith("http://") || selectedGame.coverUrl.StartsWith("https://")
                    ? selectedGame.coverUrl
                    : "https://" + selectedGame.coverUrl.TrimStart('\\'); // Fix URL

                try
                {
                    gamePanel.pictureBox1.Load(validCoverUrl); // Load the cover image
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Failed to load image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No cover image available for this game.");
            }

            
            gamePanel.Size = new Size((int)(gamePanel.Width), (int)(gamePanel.Height));

            // Add the GamePanel to FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(gamePanel);
            gamePanel.BringToFront(); // Bring the new panel to the front
        }

        public void DisplayGamePanel(GamePanel gamePanel)
    {
        // Clear existing controls or manage panels as needed
        foreach (Control control in this.Controls)
        {
            if (control is GamePanel)
            {
                this.Controls.Remove(control);
                control.Dispose(); // Dispose of old panels if necessary
            }
        }

        // Add the new GamePanel to the Form
        this.Controls.Add(gamePanel);
        gamePanel.BringToFront(); // Bring the new panel to the front
    }

        private void gameButton_Click(object sender, EventArgs e)
        {
            // Pass 'this' (Form1) as a reference to the constructor of SearchForGames
            SearchForGames searchForm = new SearchForGames(this);

            searchForm.Show(); // Show the search form
            this.Hide(); // Optionally hide the main form while searching
        }


        private void gameAddButton1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
