namespace Velocify_v1._1
{
    partial class GamePanel
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
            pictureBoxGame = new PictureBox();
            labelGame = new Label();
            settingsBtn = new Button();
            adfToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.BackColor = Color.Transparent;
            pictureBoxGame.Cursor = Cursors.Hand;
            pictureBoxGame.Location = new Point(12, 3);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(174, 211);
            pictureBoxGame.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGame.TabIndex = 0;
            pictureBoxGame.TabStop = false;
            pictureBoxGame.Click += pictureBoxGame_Click;
            // 
            // labelGame
            // 
            labelGame.AutoEllipsis = true;
            labelGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGame.ForeColor = SystemColors.ControlLightLight;
            labelGame.Location = new Point(0, 215);
            labelGame.Name = "labelGame";
            labelGame.Size = new Size(145, 38);
            labelGame.TabIndex = 1;
            labelGame.Text = "Game Name";
            labelGame.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(140, 223);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(57, 23);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "settings";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // adfToolStripMenuItem
            // 
            adfToolStripMenuItem.Name = "adfToolStripMenuItem";
            adfToolStripMenuItem.Size = new Size(180, 22);
            adfToolStripMenuItem.Text = "adf";
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(settingsBtn);
            Controls.Add(labelGame);
            Controls.Add(pictureBoxGame);
            Name = "GamePanel";
            Size = new Size(200, 257);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGame;
        private Label labelGame;
        private Button settingsBtn;
        private ToolStripMenuItem adfToolStripMenuItem;
    }
}
