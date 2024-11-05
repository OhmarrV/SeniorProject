using System.Windows.Forms;

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
            settingsDots = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsDots).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.BackColor = Color.Transparent;
            pictureBoxGame.Cursor = Cursors.Hand;
            pictureBoxGame.Location = new Point(14, 4);
            pictureBoxGame.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(199, 281);
            pictureBoxGame.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGame.TabIndex = 0;
            pictureBoxGame.TabStop = false;
            pictureBoxGame.Click += pictureBoxGame_Click;
            pictureBoxGame.MouseEnter += pictureBoxGame_MouseEnter;
            pictureBoxGame.MouseLeave += pictureBoxGame_MouseLeave;
            // 
            // labelGame
            // 
            labelGame.AutoEllipsis = true;
            labelGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGame.ForeColor = SystemColors.ActiveCaptionText;
            labelGame.Location = new Point(0, 287);
            labelGame.Name = "labelGame";
            labelGame.Size = new Size(166, 51);
            labelGame.TabIndex = 1;
            labelGame.Text = "Game Name";
            labelGame.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.FlatStyle = FlatStyle.Popup;
            settingsBtn.ForeColor = Color.Transparent;
            settingsBtn.Location = new Point(166, 297);
            settingsBtn.Margin = new Padding(3, 4, 3, 4);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(53, 40);
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
            // settingsDots
            // 
            settingsDots.Cursor = Cursors.Hand;
            settingsDots.Enabled = false;
            settingsDots.Image = Properties.Resources.settingDots;
            settingsDots.Location = new Point(166, 287);
            settingsDots.Margin = new Padding(3, 4, 3, 4);
            settingsDots.Name = "settingsDots";
            settingsDots.Size = new Size(53, 56);
            settingsDots.SizeMode = PictureBoxSizeMode.StretchImage;
            settingsDots.TabIndex = 3;
            settingsDots.TabStop = false;
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(settingsDots);
            Controls.Add(settingsBtn);
            Controls.Add(labelGame);
            Controls.Add(pictureBoxGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GamePanel";
            Size = new Size(229, 343);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsDots).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGame;
        private Label labelGame;
        private Button settingsBtn;
        private ToolStripMenuItem adfToolStripMenuItem;
        private PictureBox settingsDots;
    }
}
