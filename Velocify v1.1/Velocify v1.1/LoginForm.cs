using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class LoginForm : Form
    {
        private DatabaseHandler dbHandler;
        private int currUserId;  // Store the current user's ID

        private string username2;
        private string password2;
        private int currUser2;

        private int currUser; //user id is stored here

        public LoginForm()
        {
            InitializeComponent();
            dbHandler = new DatabaseHandler("VelocifyUsers.db"); // Path to your SQLite database file
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredUsername = usernameTextBox.Text.ToLower();
                string enteredPassword = passwordTextBox.Text;

                // Check for empty fields
                if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                Console.WriteLine($"Login attempt with Username: {enteredUsername}");

                // Authenticate the user
                int? userId = dbHandler.AuthenticateUser(enteredUsername, enteredPassword);

                if (userId.HasValue)
                {
                    currUserId = userId.Value;  // Store the current user's ID
                    MessageBox.Show($"LOGIN SUCCESSFUL: \nUser ID: {currUserId}");

                    // Load the user's games
                    List<string> userGames = dbHandler.GetUserGames(currUserId);

                    // Pass the user games to the next form (Form1 in this case)
                    Form1 form1 = new Form1(userGames, currUserId); // Form1({"1238538", "1231", 1235523", "342243"}, 0);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("LOGIN FAILED: Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Add user button click event for testing purposes
        private void addUserButton_Click(object sender, EventArgs e)
        {
            string newUsername = usernameTextBox.Text.ToLower();  // Get the new username from the textbox
            string newPassword = passwordTextBox.Text;  // Get the new password from the textbox

            // Add a new user
            dbHandler.AddUser(newUsername, newPassword);

            // Print all users for debugging
            dbHandler.PrintAllUsers();

            MessageBox.Show("New user added and users printed to console.");
        }
        private void registerLabel_Click(object sender, EventArgs e)
        {
            // Open the registration form
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();  // Show the registration form as a modal dialog
        }
    }
}
