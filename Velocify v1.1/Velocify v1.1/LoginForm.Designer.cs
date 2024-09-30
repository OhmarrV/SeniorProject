namespace Velocify_v1._1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button loginButton;
        private Button registerButton;  // Declare the register button
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();  // Initialize the register button
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(100, 150);  // Position the login button
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);

            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(100, 180);  // Position the register button below the login button
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);  // Event for register button

            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(50, 60);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 23);
            this.usernameTextBox.PlaceholderText = "Username";

            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(50, 100);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 23);
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Password";

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);  // Adjust the form size
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);  // Add the register button to the form
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
