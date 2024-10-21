using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Velocify_v1._1
{
    partial class GameAddButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addGameBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addGameBtn
            // 
            addGameBtn.Location = new Point(75, 100);
            addGameBtn.Name = "addGameBtn";
            addGameBtn.Size = new Size(50, 50);
            addGameBtn.TabIndex = 0;
            addGameBtn.Text = "Add Game";
            addGameBtn.UseVisualStyleBackColor = true;
            addGameBtn.Click += addGameBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 250);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // GameAddButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(addGameBtn);
            Controls.Add(pictureBox1);
            Name = "GameAddButton";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        public void addGameBtn_Click(object sender, EventArgs e)
        {
            SearchForGames searchForm = new SearchForGames();
            //searchForm.ShowDialog();

            if (DialogResult.OK == searchForm.ShowDialog())
            {
                string gameName = searchForm.SelectedGameName;
                string gameImg = searchForm.SelectedGameImg;
                string gameId = searchForm.SelectedGameId;



                gameAdded2(gameName, gameImg, gameId);

                int currUserId = Form1.currUserId;
                DatabaseHandler dbHandler = new DatabaseHandler("VelocifyUsers.db");
                dbHandler.AddGameToUser(currUserId, gameId);
            }
            
        }


        public static string gamePanelId { get; set; }
        private void gameAdded1(string gName, string gImg, string gId) //Working on passing in game information. Will be stored in the game added panel
        {
            // Create the GamePanel and AddNewGame button
            UserControl gamePanel = new GamePanel();
            UserControl addNewGame = new GameAddButton();

            // Change the labelGame text to the selected game name
            gamePanel.Controls["labelGame"].Text = gName;

            // Set the gamePanelId to the gameId
            gamePanelId = gId;
            MessageBox.Show("ADDBtn 111 ID: " + gId);
            MessageBox.Show("ADDBtn 111 NAME: " + gName);
            MessageBox.Show("ADDBtn 111 IMG: " + gImg);

            // Load the game image into the PictureBox
            PictureBox pictureBoxGame = gamePanel.Controls["pictureBoxGame"] as PictureBox;
            if (pictureBoxGame != null)
            {
                pictureBoxGame.LoadAsync("https:" + gImg);
            }

            //// Add the GamePanel and AddNewGame button to the parent container (gameLibraryPanel)
            //Panel parentPanel = this.Parent as Panel;
            //parentPanel.Controls.Add(gamePanel);
            //parentPanel.Controls.Add(addNewGame);

            //// Remove this GameAddButton from the parent (if needed)
            //this.Parent?.Controls.Remove(this);

            gameAdded2(gName, gImg, gId);
        }

        private void gameAdded2(string gName, string gImg, string gId) //Working on passing in game information. Will be stored in the game added panel
        {
            if (this.Parent != null)
            {
                //    //replace the GameAddButton with the GamePanel
                UserControl gamePanel = new GamePanel();
                UserControl addNewGame = new GameAddButton();

                //change the labelGame text to the selected game
                gamePanel.Controls["labelGame"].Text = gName;

                gamePanelId = gId;
                MessageBox.Show("ADDBtn ID: " + gamePanelId);



                PictureBox pictureBoxGame = gamePanel.Controls["pictureBoxGame"] as PictureBox;
                pictureBoxGame.LoadAsync("https:" + gImg);
                //gamePanel.Controls["pictureBoxGame"].Load(gImg);

                //string parentType = this.Parent.GetType().ToString();
                //string parentName = this.Parent.Name;
                //MessageBox.Show("PARENT NAME: " + parentName + "\nPARENT TYPE: " + parentType);

                this.Parent.Controls.Add(gamePanel);
                this.Parent.Controls.Add(addNewGame);
                this.Parent.Controls.Remove(this);
            }
            else
            {

                Form1 parentForm = this.FindForm() as Form1;
                GamePanelFLEX gamePanelFlex = this.Parent as GamePanelFLEX;
                //GamePanelFLEX gamePanelFlex = new GamePanelFLEX();
                //FlowLayoutPanel gameLibraryPanel = gamePanelFlex.Controls["gameLibraryPanel"] as FlowLayoutPanel;

                //string parentType = gameLibraryPanel.Parent.GetType().ToString();
                //string parentName = gameLibraryPanel.Parent.Name;
                //MessageBox.Show("PARENT NAME: " + parentName + "\nPARENT TYPE: " + parentType);

                // Create the GamePanel and AddNewGame button
                UserControl gamePanel = new GamePanel();
                UserControl addNewGame = new GameAddButton();

                // Change the labelGame text to the selected game
                gamePanel.Controls["labelGame"].Text = gName;

                // Set the gamePanelId to the gameId
                gamePanelId = gId;
                MessageBox.Show("ADDBtn ID: " + gamePanelId);

                // Load the game image into the PictureBox
                PictureBox pictureBoxGame = gamePanel.Controls["pictureBoxGame"] as PictureBox;
                if (pictureBoxGame != null)
                {
                    pictureBoxGame.LoadAsync("https:" + gImg);
                }

                // Add the GamePanel and AddNewGame button to the gameLibraryPanel
                //gameLibraryPanel.Controls.Add(gamePanel);
                //gameLibraryPanel.Controls.Add(addNewGame); 10/21 BROEKN

                // Optionally remove this GameAddButton
                this.Parent?.Controls.Remove(this);

            }
        }



        public async void loadGamesAdded(string gameId) // Use gameId from the database
        {
            var gameDataResponse = await APIFile.GetGameByIdAsync(gameId);

            JArray gameDataArray = JArray.Parse(gameDataResponse);

            if (gameDataArray.Count > 0)
            {
                // Extract the first game object from the array
                JObject gameData = (JObject)gameDataArray[0];

                // Extract the game name and image URL from the API response
                string gName = gameData["name"]?.ToString() ?? "Unknown Game";
                string gImg = gameData["cover"]?["url"]?.ToString() ?? "No Image";

                // Reuse the gameAdded1 method to update the UI
                gameAdded1(gName, gImg, gameId);
            }

        }

        public void LOADaddGameBtn_Click()
        {
                SearchForGames searchForm = new SearchForGames();

                string gameName = searchForm.SelectedGameName;
                string gameImg = searchForm.SelectedGameImg;
                string gameId = searchForm.SelectedGameId;



                gameAdded2(gameName, gameImg, gameId);
            

        }

        #endregion

        private Button addGameBtn;
        private PictureBox pictureBox1;
    }
}
