namespace Velocify_v1._1
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            userInfoPanel = new Panel();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            loginPanel.SuspendLayout();
            userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginPanel.BackColor = SystemColors.HotTrack;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(userInfoPanel);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Controls.Add(label1);
            loginPanel.Location = new Point(0, -1);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(799, 453);
            loginPanel.TabIndex = 2;
            // 
            // userInfoPanel
            // 
            userInfoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            userInfoPanel.BackColor = SystemColors.Highlight;
            userInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            userInfoPanel.Controls.Add(loginButton);
            userInfoPanel.Controls.Add(passwordTextBox);
            userInfoPanel.Controls.Add(usernameTextBox);
            userInfoPanel.ForeColor = Color.Black;
            userInfoPanel.Location = new Point(262, 115);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(279, 225);
            userInfoPanel.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(98, 152);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(52, 105);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(166, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(52, 58);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(166, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(103, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Candara", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(52, 188);
            label1.Name = "label1";
            label1.Size = new Size(163, 41);
            label1.TabIndex = 3;
            label1.Text = "VELOCIFY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(815, 490);
            MinimumSize = new Size(815, 490);
            Name = "LoginForm";
            Text = "Form2";
            loginPanel.ResumeLayout(false);
            userInfoPanel.ResumeLayout(false);
            userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Panel userInfoPanel;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private PictureBox pictureBox1;
        private Label label1;
    }
}