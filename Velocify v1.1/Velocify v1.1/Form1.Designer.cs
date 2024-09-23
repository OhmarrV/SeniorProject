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
            flowLayoutPanel1 = new FlowLayoutPanel();
            gameAddButton1 = new GameAddButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            gameButton = new Button();
            panel2 = new Panel();
            userInfo1 = new UserInfo();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Controls.Add(gameAddButton1);
            flowLayoutPanel1.Location = new Point(155, 75);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(743, 527);
            flowLayoutPanel1.TabIndex = 0;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(gameButton);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 607);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(43, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 100);
            label1.Name = "label1";
            label1.Size = new Size(157, 55);
            label1.TabIndex = 3;
            label1.Text = "VELOCIFY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(1, 388);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 83);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "netButton";
            button2.Location = new Point(1, 281);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 83);
            button2.TabIndex = 1;
            button2.Text = "Networking";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // gameButton
            // 
            gameButton.Location = new Point(1, 175);
            gameButton.Margin = new Padding(3, 4, 3, 4);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(154, 83);
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
            panel2.Location = new Point(155, -1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 76);
            panel2.TabIndex = 2;
            // 
            // userInfo1
            // 
            userInfo1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userInfo1.BackColor = Color.Transparent;
            userInfo1.Location = new Point(686, 13);
            userInfo1.Margin = new Padding(3, 5, 3, 5);
            userInfo1.Name = "userInfo1";
            userInfo1.Size = new Size(46, 53);
            userInfo1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button gameButton;
        private Label label1;
        private PictureBox pictureBox1;
        private GameAddButton gameAddButton1;
        private UserInfo userInfo1;
    }
}
