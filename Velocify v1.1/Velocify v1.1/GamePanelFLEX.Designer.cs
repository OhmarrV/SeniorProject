using Newtonsoft.Json.Linq;

namespace Velocify_v1._1
{
    partial class GamePanelFLEX
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
            gameLibraryPanel = new FlowLayoutPanel();
            gameAddButton1 = new GameAddButton();
            gameLibraryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gameLibraryPanel
            // 
            gameLibraryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameLibraryPanel.AutoScroll = true;
            gameLibraryPanel.BackColor = SystemColors.ButtonFace;
            gameLibraryPanel.Controls.Add(gameAddButton1);
            gameLibraryPanel.Location = new Point(0, 0);
            gameLibraryPanel.Margin = new Padding(3, 4, 3, 4);
            gameLibraryPanel.Name = "gameLibraryPanel";
            gameLibraryPanel.Size = new Size(743, 527);
            gameLibraryPanel.TabIndex = 5;
            // 
            // gameAddButton1
            // 
            gameAddButton1.BackColor = Color.Transparent;
            gameAddButton1.Location = new Point(3, 5);
            gameAddButton1.Margin = new Padding(3, 5, 3, 5);
            gameAddButton1.Name = "gameAddButton1";
            gameAddButton1.Size = new Size(229, 333);
            gameAddButton1.TabIndex = 0;
            gameAddButton1.Load += gameAddButton1_Load;
            // 
            // GamePanelFLEX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gameLibraryPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GamePanelFLEX";
            Size = new Size(743, 527);
            gameLibraryPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel gameLibraryPanel;
        private GameAddButton gameAddButton1;

        public async void gameAddBtnLoad(string id)
        {
            GamePanel gamePanel = new GamePanel();
            var gameDataResponse = await APIFile.GetGameByIdAsync(id);
            JArray gameDataArray = JArray.Parse(gameDataResponse);

            if (gameDataArray.Count > 0)
            {
                // Extract the first game object from the array
                JObject gameData = (JObject)gameDataArray[0];

                // Extract the game name and image URL from the API response
                string gName = gameData["name"]?.ToString() ?? "Unknown Game";
                string gImg = gameData["cover"]?["url"]?.ToString() ?? "No Image";

                gamePanel.Controls["labelGame"].Text = gName;
                PictureBox pictureBoxGame = gamePanel.Controls["pictureBoxGame"] as PictureBox;

                if (pictureBoxGame != null)
                {
                    gImg = gImg.Replace("t_thumb", "t_cover_big");
                    pictureBoxGame.Load("https:" + gImg);
                }

                gamePanel.Controls["settingsBtn"].Tag = id;

            }

            gameLibraryPanel.Controls.Add(gamePanel);
            gameLibraryPanel.Controls.Remove(gameAddButton1);

            gameLibraryPanel.Controls.Add(gameAddButton1);
            gameLibraryPanel.ResumeLayout(false);

        }
    }



}
