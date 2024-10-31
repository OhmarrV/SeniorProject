namespace Velocify_v1._1
{
    partial class OptimizationPanelFlex
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
            settingsPanel = new Panel();
            nameUi = new PictureBox();
            namePanel = new Panel();
            gameLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nameUi).BeginInit();
            namePanel.SuspendLayout();
            SuspendLayout();
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsPanel.AutoScroll = true;
            settingsPanel.BackColor = SystemColors.ActiveCaption;
            settingsPanel.Location = new Point(0, 70);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(650, 325);
            settingsPanel.TabIndex = 0;
            // 
            // nameUi
            // 
            nameUi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameUi.BackColor = Color.Transparent;
            nameUi.Image = Properties.Resources.name_line;
            nameUi.Location = new Point(6, 3);
            nameUi.Name = "nameUi";
            nameUi.Size = new Size(638, 61);
            nameUi.SizeMode = PictureBoxSizeMode.StretchImage;
            nameUi.TabIndex = 1;
            nameUi.TabStop = false;
            // 
            // namePanel
            // 
            namePanel.BackColor = Color.RosyBrown;
            namePanel.Controls.Add(gameLabel);
            namePanel.Controls.Add(nameUi);
            namePanel.Dock = DockStyle.Top;
            namePanel.Location = new Point(0, 0);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(650, 68);
            namePanel.TabIndex = 1;
            // 
            // gameLabel
            // 
            gameLabel.Anchor = AnchorStyles.None;
            gameLabel.AutoEllipsis = true;
            gameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(147, 11);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(356, 45);
            gameLabel.TabIndex = 2;
            gameLabel.Text = "Game Name";
            gameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chartreuse;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 395);
            panel1.TabIndex = 0;
            // 
            // OptimizationPanelFlex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(namePanel);
            Controls.Add(settingsPanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OptimizationPanelFlex";
            Size = new Size(650, 395);
            ((System.ComponentModel.ISupportInitialize)nameUi).EndInit();
            namePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel settingsPanel;
        private PictureBox nameUi;
        private Panel namePanel;
        private Label gameLabel;
        private Panel panel1;
    }
}
