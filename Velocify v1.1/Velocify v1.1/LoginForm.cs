using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Velocify_v1._1
{
    public partial class LoginForm : Form
    {
        private DatabaseHandler dbHandler;
        private DatabaseHelper dbHelper;
        private int currUserId;  // Store the current user's ID
        private string currToken;
        private string username2;
        private string password2;
        private int currUser2;

        private int currUser; //user id is stored here


        public static int globalId { get; set; }


        public LoginForm()
        {
            
            dbHandler = new DatabaseHandler();
            dbHelper = new DatabaseHelper();

            int savedUserId = globalId;


           InitializeComponent();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredUsername = usernameTextBox.Text.ToLower();
                string enteredPassword = passwordTextBox.Text;

                if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                Console.WriteLine($"Login attempt with Username: {enteredUsername}");

                int? userId = dbHandler.AuthenticateUser(enteredUsername, enteredPassword);

                if (userId.HasValue)
                {
                    currUserId = userId.Value;
                    globalId = currUserId;
                    MessageBox.Show($"LOGIN SUCCESSFUL: \nUser ID: {currUserId}");

                    // If "Stay logged in" is checked, save the session token and set current_token
                    if (checkBox1.Checked)
                    {
                        string sessionToken = GenerateSessionToken();
                        dbHelper.SaveSessionToken(currUserId, sessionToken);
                        Console.WriteLine("Session token saved for 'Stay logged in' feature.");
                    }

                    OpenMainForm(currUserId);
                }
                else
                {
                    MessageBox.Show("LOGIN FAILED: Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public string GenerateSessionToken()
        {
            return Guid.NewGuid().ToString();
        }

        

        private void OpenMainForm(int userId)
        {
            Form1 form1 = new Form1(userId);
            form1.Show();
            this.Hide();
        }




    }
}
