using System.Drawing.Imaging;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(netButton);
            panel1.Controls.Add(gameButton);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 759);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.velocify_logo_SOLO;
            pictureBox1.Location = new Point(48, 24);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 69);
            label1.TabIndex = 3;
            label1.Text = "Velocify";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(-10, 485);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(215, 104);
            button3.TabIndex = 2;
            button3.Text = "User Feedback";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // netButton
            // 
            netButton.AccessibleName = "";
            netButton.BackColor = SystemColors.Control;
            netButton.BackgroundImageLayout = ImageLayout.Zoom;
            netButton.FlatStyle = FlatStyle.Popup;
            netButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            netButton.ForeColor = SystemColors.ControlText;
            netButton.ImageAlign = ContentAlignment.MiddleLeft;
            netButton.Location = new Point(-10, 318);
            netButton.Margin = new Padding(4, 5, 4, 5);
            netButton.Name = "netButton";
            netButton.Padding = new Padding(12, 0, 0, 0);
            netButton.Size = new Size(215, 104);
            netButton.TabIndex = 1;
            netButton.Text = "Networking";
            netButton.UseVisualStyleBackColor = false;
            netButton.Click += netButton_Click;
            // 
            // gameButton
            // 
            gameButton.BackColor = SystemColors.Control;
            gameButton.BackgroundImageLayout = ImageLayout.Zoom;
            gameButton.FlatAppearance.MouseOverBackColor = Color.Red;
            gameButton.FlatStyle = FlatStyle.Popup;
            gameButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            gameButton.Image = (Image)resources.GetObject("gameButton.Image");
            gameButton.ImageAlign = ContentAlignment.MiddleLeft;
            gameButton.Location = new Point(-10, 215);
            gameButton.Margin = new Padding(4, 5, 4, 5);
            gameButton.Name = "gameButton";
            gameButton.Padding = new Padding(12, 0, 0, 0);
            gameButton.Size = new Size(215, 104);
            gameButton.TabIndex = 0;
            gameButton.Text = "Games";
            gameButton.UseVisualStyleBackColor = false;
            gameButton.Click += gameButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(userInfo1);
            panel2.Location = new Point(194, -1);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 95);
            panel2.TabIndex = 2;
            // 
            // userInfo1
            // 
            userInfo1.AccessibleRole = AccessibleRole.PushButton;
            userInfo1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userInfo1.BackColor = Color.Transparent;
            userInfo1.Location = new Point(854, 16);
            userInfo1.Margin = new Padding(4, 6, 4, 6);
            userInfo1.Name = "userInfo1";
            userInfo1.Size = new Size(61, 66);
            userInfo1.TabIndex = 0;
            userInfo1.Load += userInfo1_Load;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.ActiveCaptionText;
            mainPanel.Location = new Point(194, 94);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(929, 664);
            mainPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
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

        // Set the opacity of the image within the button
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Set the opacity level

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
    }
}
