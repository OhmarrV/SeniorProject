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
            specBtn = new Button();
            gameLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nameUi).BeginInit();
            namePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsPanel.AutoScroll = true;
            settingsPanel.BackColor = SystemColors.Control;
            settingsPanel.Location = new Point(0, 74);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(650, 321);
            settingsPanel.TabIndex = 0;
            // 
            // nameUi
            // 
            nameUi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameUi.BackColor = Color.Transparent;
            nameUi.Image = Properties.Resources.name_line;
            nameUi.Location = new Point(6, 5);
            nameUi.Name = "nameUi";
            nameUi.Size = new Size(638, 61);
            nameUi.SizeMode = PictureBoxSizeMode.StretchImage;
            nameUi.TabIndex = 1;
            nameUi.TabStop = false;
            // 
            // namePanel
            // 
            namePanel.BackColor = SystemColors.Control;
            namePanel.Controls.Add(button3);
            namePanel.Controls.Add(Wiki);
            namePanel.Controls.Add(specBtn);
            namePanel.Controls.Add(gameLabel);
            namePanel.Controls.Add(nameUi);
            namePanel.Dock = DockStyle.Top;
            namePanel.Location = new Point(0, 0);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(650, 71);
            namePanel.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = SystemColors.ControlLightLight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(74, 44);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(74, 22);
            button3.TabIndex = 5;
            button3.Text = "Game Scan";
            button3.UseVisualStyleBackColor = false;
            // 
            // Wiki
            // 
            Wiki.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Wiki.BackColor = SystemColors.ControlLightLight;
            Wiki.FlatStyle = FlatStyle.Popup;
            Wiki.Location = new Point(6, 44);
            Wiki.Margin = new Padding(3, 2, 3, 2);
            Wiki.Name = "Wiki";
            Wiki.Size = new Size(62, 22);
            Wiki.TabIndex = 4;
            Wiki.Text = "Wiki";
            Wiki.UseVisualStyleBackColor = false;
            // 
            // specBtn
            // 
            specBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            specBtn.BackColor = SystemColors.ControlLightLight;
            specBtn.FlatStyle = FlatStyle.Popup;
            specBtn.Location = new Point(561, 44);
            specBtn.Margin = new Padding(3, 2, 3, 2);
            specBtn.Name = "specBtn";
            specBtn.Size = new Size(83, 22);
            specBtn.TabIndex = 3;
            specBtn.Text = "PC Specs.";
            specBtn.UseVisualStyleBackColor = false;
            specBtn.Click += specBtn_Click;
            // 
            // gameLabel
            // 
            gameLabel.Anchor = AnchorStyles.None;
            gameLabel.AutoEllipsis = true;
            gameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(147, 13);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(356, 45);
            gameLabel.TabIndex = 2;
            gameLabel.Text = "Game Name";
            gameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(settingsPanel);
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
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OptimizationPanelFlex";
            Size = new Size(650, 395);
            ((System.ComponentModel.ISupportInitialize)nameUi).EndInit();
            namePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel settingsPanel;
        private PictureBox nameUi;
        private Panel namePanel;
        private Label gameLabel;
        private Panel panel1;
        private Button specBtn;
        private Button button3;
        private Button Wiki;
    }
}
