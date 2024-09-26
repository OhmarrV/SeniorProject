namespace Velocify_v1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            netButton = new Button();
            gameButton = new Button();
            panel2 = new Panel();
            userInfo1 = new UserInfo();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(netButton);
            panel1.Controls.Add(gameButton);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 455);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(38, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 75);
            label1.Name = "label1";
            label1.Size = new Size(137, 41);
            label1.TabIndex = 3;
            label1.Text = "VELOCIFY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(1, 291);
            button3.Name = "button3";
            button3.Size = new Size(135, 62);
            button3.TabIndex = 2;
            button3.Text = "API Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // netButton
            // 
            netButton.AccessibleName = "";
            netButton.Location = new Point(1, 211);
            netButton.Name = "netButton";
            netButton.Size = new Size(135, 62);
            netButton.TabIndex = 1;
            netButton.Text = "Networking";
            netButton.UseVisualStyleBackColor = true;
            netButton.Click += netButton_Click;
            // 
            // gameButton
            // 
            gameButton.Location = new Point(1, 131);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(135, 62);
            gameButton.TabIndex = 0;
            gameButton.Text = "Games";
            gameButton.UseVisualStyleBackColor = true;
            gameButton.Click += gameButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(userInfo1);
            panel2.Location = new Point(136, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 57);
            panel2.TabIndex = 2;
            // 
            // userInfo1
            // 
            userInfo1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userInfo1.BackColor = Color.Transparent;
            userInfo1.Location = new Point(600, 10);
            userInfo1.Margin = new Padding(3, 4, 3, 4);
            userInfo1.Name = "userInfo1";
            userInfo1.Size = new Size(40, 40);
            userInfo1.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.ActiveCaptionText;
            mainPanel.Location = new Point(136, 56);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(650, 398);
            mainPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button netButton;
        private Button gameButton;
        private Label label1;
        private PictureBox pictureBox1;
        private UserInfo userInfo1;
        private GamePanelFLEX gamePanelflex1;
        private PictureBox pictureBox2;
        private Panel mainPanel;
        
    }
}
