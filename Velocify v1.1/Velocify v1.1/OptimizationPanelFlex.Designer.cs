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
            settingsPanel.Location = new Point(0, 99);
            settingsPanel.Margin = new Padding(3, 4, 3, 4);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(743, 428);
            settingsPanel.TabIndex = 0;
            // 
            // nameUi
            // 
            nameUi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameUi.BackColor = Color.Transparent;
            nameUi.Image = Properties.Resources.name_line;
            nameUi.Location = new Point(7, 7);
            nameUi.Margin = new Padding(3, 4, 3, 4);
            nameUi.Name = "nameUi";
            nameUi.Size = new Size(729, 81);
            nameUi.SizeMode = PictureBoxSizeMode.StretchImage;
            nameUi.TabIndex = 1;
            nameUi.TabStop = false;
            // 
            // namePanel
            // 
            namePanel.BackColor = SystemColors.Control;
            namePanel.Controls.Add(specBtn);
            namePanel.Controls.Add(gameLabel);
            namePanel.Controls.Add(nameUi);
            namePanel.Dock = DockStyle.Top;
            namePanel.Location = new Point(0, 0);
            namePanel.Margin = new Padding(3, 4, 3, 4);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(743, 95);
            namePanel.TabIndex = 1;
            // 
            // specBtn
            // 
            specBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            specBtn.Location = new Point(642, 59);
            specBtn.Name = "specBtn";
            specBtn.Size = new Size(94, 29);
            specBtn.TabIndex = 3;
            specBtn.Text = "PC Specs.";
            specBtn.UseVisualStyleBackColor = true;
            specBtn.Click += specBtn_Click;
            // 
            // gameLabel
            // 
            gameLabel.Anchor = AnchorStyles.None;
            gameLabel.AutoEllipsis = true;
            gameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(168, 17);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(407, 60);
            gameLabel.TabIndex = 2;
            gameLabel.Text = "Game Name";
            gameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(settingsPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 527);
            panel1.TabIndex = 0;
            // 
            // OptimizationPanelFlex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(namePanel);
            Controls.Add(panel1);
            Name = "OptimizationPanelFlex";
            Size = new Size(743, 527);
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
    }
}
