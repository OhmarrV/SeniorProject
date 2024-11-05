using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SQLite;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Velocify_v1._1
{
    public partial class Form1 : Form
    {
        private List<string> userGames;
        private int userId;
        public static int currUserId { get; set; }

        public FlowLayoutPanel gameLibraryPanel;
        GamePanelFLEX gamePanelFlex = new GamePanelFLEX();


        public Form1(int userId)
        {

            InitializeComponent();
            this.Opacity = 0; //Loads form in the background

            mainPanel.Controls.Clear();

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

            //LoadUserGames(userId);
        }



        private void gameButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls[0].Name != "GamePanelFLEX")
            {
                mainPanel.Controls.Clear();
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
            OptimizationPanelFlex optiFlex = new OptimizationPanelFlex(gameId);
            optiFlex.Dock = DockStyle.Fill;
            optiFlex.Show();
            mainPanel.Controls.Add(optiFlex);
        }

        private void LoadUserGames(int userId)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            List<string> gameIds = dbHandler.LoadUserGames(userId);

            foreach (string gameId in gameIds)
            {
                // Load each game panel using the game ID
                gamePanelFlex.gameAddBtnLoad(gameId);
            }
        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.Tag = currUserId;
        }

        private async Task LoadFormAsync(int userId)
        {
            // Show the loading form
            using (LoadingForm loadingForm = new LoadingForm())
            {
                loadingForm.Show();
                loadingForm.Refresh();

                // Load the user games directly on the main thread
                LoadUserGames(userId);

                // Ensure LoadingForm is displayed for at least 2 seconds
                await Task.Delay(2000);

                // Close the loading form after loading completes and delay
                loadingForm.Close();
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            // Start loading user games asynchronously
            await LoadFormAsync(userId);

            this.Opacity = 1;

        }
    }
}
