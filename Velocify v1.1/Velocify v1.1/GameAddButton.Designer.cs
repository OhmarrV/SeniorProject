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



                gameAdded(gameName, gameImg, gameId);

                int currUserId = Form1.currUserId;
                DatabaseHandler dbHandler = new DatabaseHandler("VelocifyUsers.db");
                dbHandler.AddGameToUser(currUserId, gameId);
            }



        }

        


        public static string gamePanelId { get; set; }
        private void gameAdded(string gName, string gImg, string gId) //Working on passing in game information. Will be stored in the game added panel
        {
            //    //replace the GameAddButton with the GamePanel
            UserControl gamePanel = new GamePanel();
            UserControl addNewGame = new GameAddButton();

            //change the labelGame text to the selected game
            gamePanel.Controls["labelGame"].Text = gName;

            gamePanelId = gId;

            PictureBox pictureBoxGame = gamePanel.Controls["pictureBoxGame"] as PictureBox;
            if (!string.IsNullOrEmpty(gImg))
            {
                gImg = gImg.Replace("t_thumb", "t_cover_big");
            }
            pictureBoxGame.LoadAsync("https:" + gImg);

            this.Parent.Controls.Add(gamePanel);
            this.Parent.Controls.Add(addNewGame);
            this.Parent.Controls.Remove(this); 
        }


        
        #endregion

        private Button addGameBtn;
        private PictureBox pictureBox1;
    }
}
