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
            button3 = new Button();
            Wiki = new Button();
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
            settingsPanel.BackColor = SystemColors.ActiveBorder;
            settingsPanel.Location = new Point(0, 116);
            settingsPanel.Margin = new Padding(4, 5, 4, 5);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(929, 541);
            settingsPanel.TabIndex = 0;
            // 
            // nameUi
            // 
            nameUi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameUi.BackColor = Color.Transparent;
            nameUi.Image = Properties.Resources.name_line;
            nameUi.Location = new Point(9, 5);
            nameUi.Margin = new Padding(4, 5, 4, 5);
            nameUi.Name = "nameUi";
            nameUi.Size = new Size(911, 101);
            nameUi.SizeMode = PictureBoxSizeMode.StretchImage;
            nameUi.TabIndex = 1;
            nameUi.TabStop = false;
            // 
            // namePanel
            // 
            namePanel.BackColor = Color.Gainsboro;
            namePanel.Controls.Add(button3);
            namePanel.Controls.Add(Wiki);
            namePanel.Controls.Add(gameLabel);
            namePanel.Controls.Add(nameUi);
            namePanel.Dock = DockStyle.Top;
            namePanel.Location = new Point(0, 0);
            namePanel.Margin = new Padding(4, 5, 4, 5);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(929, 114);
            namePanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(84, 60);
            button3.Name = "button3";
            button3.Size = new Size(131, 34);
            button3.TabIndex = 1;
            button3.Text = "GameScan";
            button3.UseVisualStyleBackColor = true;
            // 
            // Wiki
            // 
            Wiki.Location = new Point(726, 60);
            Wiki.Name = "Wiki";
            Wiki.Size = new Size(112, 34);
            Wiki.TabIndex = 3;
            Wiki.Text = "Wiki";
            Wiki.UseVisualStyleBackColor = true;
            // 
            // gameLabel
            // 
            gameLabel.Anchor = AnchorStyles.None;
            gameLabel.AutoEllipsis = true;
            gameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(210, 19);
            gameLabel.Margin = new Padding(4, 0, 4, 0);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(509, 75);
            gameLabel.TabIndex = 2;
            gameLabel.Text = "Game Name";
            gameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 659);
            panel1.TabIndex = 0;
            // 
            // OptimizationPanelFlex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(namePanel);
            Controls.Add(settingsPanel);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "OptimizationPanelFlex";
            Size = new Size(929, 659);
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
        private Button Wiki;
        private Button button3;
    }
}
