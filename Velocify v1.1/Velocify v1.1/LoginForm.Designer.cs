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
            registerLabel = new Label();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
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
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(913, 603);
            loginPanel.TabIndex = 2;
            // 
            // userInfoPanel
            // 
            userInfoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            userInfoPanel.BackColor = SystemColors.Highlight;
            userInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            userInfoPanel.Controls.Add(checkBox1);
            userInfoPanel.Controls.Add(registerLabel);
            userInfoPanel.Controls.Add(loginButton);
            userInfoPanel.Controls.Add(passwordTextBox);
            userInfoPanel.Controls.Add(usernameTextBox);
            userInfoPanel.ForeColor = Color.Black;
            userInfoPanel.Location = new Point(299, 153);
            userInfoPanel.Margin = new Padding(3, 4, 3, 4);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(318, 299);
            userInfoPanel.TabIndex = 5;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.WhiteSmoke;
            registerLabel.Location = new Point(127, 241);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(63, 20);
            registerLabel.TabIndex = 3;
            registerLabel.Text = "Register";
            registerLabel.Click += registerLabel_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(112, 203);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(59, 140);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(189, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(59, 77);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(189, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(118, 167);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Candara", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(59, 251);
            label1.Name = "label1";
            label1.Size = new Size(186, 55);
            label1.TabIndex = 3;
            label1.Text = "VELOCIFY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(90, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Stay Logged In";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 591);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(929, 638);
            MinimumSize = new Size(929, 638);
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
        private Label registerLabel;
        private CheckBox checkBox1;
    }
}