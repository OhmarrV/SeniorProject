using Microsoft.VisualBasic.ApplicationServices;

namespace Velocify_v1._1
{
    public partial class Form1 : Form
    {
        private List<string> userGames;
        private int userId;
        public Form1(List<string> games, int userId)
        {
            InitializeComponent();

            mainPanel.Controls.Clear();
            GamePanelFLEX gamePanelFlex = new GamePanelFLEX();
            gamePanelFlex.Dock = DockStyle.Fill;
            gamePanelFlex.Show();
            mainPanel.Controls.Add(gamePanelFlex);

            this.userGames = games;  // Store the list of games
            this.userId = userId;    // Store the current user's ID

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

        public void change_Panel()//PASS IN GAME_ID 
        {
            mainPanel.Controls.Clear();
            OptimizationPanelFlex optiFlex = new OptimizationPanelFlex();
            optiFlex.Dock = DockStyle.Fill;
            optiFlex.Show();
            mainPanel.Controls.Add(optiFlex);
        }
    }
}
