using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class LoginForm : Form
    {
        private string username1 = "user1";
        private string password1 = "Pass1";
        private string username2 = string.Empty;
        private string password2 = string.Empty;
        private int currUser2;

        public LoginForm()
        {
            InitializeComponent();

            // Fetch additional user info from the database
            DatabaseHelper db = new DatabaseHelper();

            using (SQLiteDataReader reader = db.GetUserInfo())
            {
                while (reader.Read())
                {
                    username2 = reader["username"]?.ToString() ?? string.Empty;
                    password2 = reader["password"]?.ToString() ?? string.Empty;
                    currUser2 = Convert.ToInt32(reader["id"]);
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text.ToLower();
            string enteredPassword = passwordTextBox.Text;

            DatabaseHelper db = new DatabaseHelper();
            bool loginSuccess = false;

            using (SQLiteDataReader reader = db.GetUserInfo())
            {
                while (reader.Read())
                {
                    string dbUsername = reader["username"]?.ToString()?.ToLower();
                    string dbPassword = reader["password"]?.ToString();

                    if (dbUsername == enteredUsername && dbPassword == enteredPassword)
                    {
                        loginSuccess = true;
                        currUser2 = Convert.ToInt32(reader["id"]);  // Store current user ID
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show($"LOGIN SUCCESSFUL: \nUser ID: {currUser2}");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED: Invalid username or password.");
            }
        }

        // Event for Register Button
        private void registerButton_Click(object sender, EventArgs e)
        {
            // Open the registration form
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();  // Show the registration form as a modal dialog
        }
    }
}
