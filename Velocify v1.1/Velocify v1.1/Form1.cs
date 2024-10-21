using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace Velocify_v1._1
{
    public partial class Form1 : Form
    {
        private List<string> userGames;
        private int userId;
        public static int currUserId { get; set; }

        public FlowLayoutPanel gameLibraryPanel;

        public Form1(int userId)
        {
            InitializeComponent();

            mainPanel.Controls.Clear();
            GamePanelFLEX gamePanelFlex = new GamePanelFLEX();
            gamePanelFlex.Dock = DockStyle.Fill;
            gamePanelFlex.Show();
            mainPanel.Controls.Add(gamePanelFlex);

            //this.userGames = games;  // Store the list of games
            this.userId = userId;    // Store the current user's ID

            currUserId = userId;

            this.gameLibraryPanel = new FlowLayoutPanel();
            this.gameLibraryPanel.Name = "gameLibraryPanel";
            this.gameLibraryPanel.Size = new System.Drawing.Size(400, 400);
            this.gameLibraryPanel.FlowDirection = FlowDirection.TopDown;
            this.gameLibraryPanel.AutoScroll = true;

            this.Controls.Add(this.gameLibraryPanel);

            load_UserGames();
        }



        private void gameButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls[0].Name != "GamePanelFLEX")
            {
                mainPanel.Controls.Clear();
                //add gamePanelFlex onto panel3
                GamePanelFLEX gamePanelFlex = new GamePanelFLEX();
                gamePanelFlex.Dock = DockStyle.Fill;
                gamePanelFlex.Show();
                mainPanel.Controls.Add(gamePanelFlex);
            }
            MessageBox.Show(mainPanel.Controls[0].Name);
        }


        private void netButton_Click(object sender, EventArgs e)
        {

            if (mainPanel.Controls[0].Name != "NetworkPanelFLEX")
            {
                mainPanel.Controls.Clear();
                NetworkPanelFLEX netPanelFlex = new NetworkPanelFLEX();
                netPanelFlex.Dock = DockStyle.Fill;
                netPanelFlex.Show();
                mainPanel.Controls.Add(netPanelFlex);
                mainPanel.Controls[0].Name = "NetworkPanelFLEX"; //BUG HERE mainPanel.Controls[0].Name is set to NetowrkPanelFLEX with network misspelled
            }
            else
            {
                MessageBox.Show("Already on Network Panel");
            }

            MessageBox.Show(mainPanel.Controls[0].Name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            APITestForm APIForm = new APITestForm();
            APIForm.Show();
            this.Hide();

        }

        public void change_Panel(string gameId)//PASS IN GAME_ID 
        {
            //USE GAMEID TO CHANGE TO SPECIFIC PANEL WITH GAME INFO
            mainPanel.Controls.Clear();
            OptimizationPanelFlex optiFlex = new OptimizationPanelFlex();
            optiFlex.Dock = DockStyle.Fill;
            optiFlex.Show();
            mainPanel.Controls.Add(optiFlex);
        }

        private void load_UserGames() 
        {
            List<string> gameIds = new List<string>();

            // SQL query to get all game IDs for the specified user ID
            string query = "SELECT game_id FROM UserGames WHERE user_id = @userId";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\omarv\\OneDrive\\Documents\\Fall 24 Workspace\\Senior Project git\\10-20 Branch\\SeniorProject\\VelocifyUsers.db;Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currUserId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // Loop through the results
                        while (reader.Read())
                        {
                            // Get the game_id from the current row
                            string gameId = reader["game_id"].ToString();
                            gameIds.Add(gameId);  // Add the game_id to the list
                        }
                    }
                }
            }

            // For each gameId retrieved, call loadGamesAdded
            foreach (string gameId in gameIds)
            {
                // Create a new GameAddButton and pass the parent container (gameLibraryPanel)
                GameAddButton gameAddButton = new GameAddButton();
                gameAddButton.loadGamesAdded(gameId);  // Pass gameLibraryPanel as parent
            }
        }



    }
}
