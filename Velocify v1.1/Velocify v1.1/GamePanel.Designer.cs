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
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGame
            // 
            pictureBoxGame.BackColor = Color.Transparent;
            pictureBoxGame.Cursor = Cursors.Hand;
            pictureBoxGame.Location = new Point(3, 4);
            pictureBoxGame.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGame.Name = "pictureBoxGame";
            pictureBoxGame.Size = new Size(222, 279);
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
            labelGame.Location = new Point(0, 283);
            labelGame.Name = "labelGame";
            labelGame.Size = new Size(166, 56);
            labelGame.TabIndex = 1;
            labelGame.Text = "Game Name";
            labelGame.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(160, 299);
            settingsBtn.Margin = new Padding(3, 4, 3, 4);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(65, 31);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "button1";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += button1_Click;
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(settingsBtn);
            Controls.Add(labelGame);
            Controls.Add(pictureBoxGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GamePanel";
            Size = new Size(229, 333);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGame;
        private Label labelGame;
        private Button settingsBtn;
    }
}
