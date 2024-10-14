using System;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Define the submitButton_Click method
        private void submitButton_Click(object sender, EventArgs e)
        {
            string newUsername = usernameTextBox.Text;
            string newPassword = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // You would add your logic here to save the new user to the database
            DatabaseHelper db = new DatabaseHelper();
            bool userCreated = db.CreateUser(newUsername, newPassword);

            if (userCreated)
            {
                MessageBox.Show("Registration successful!");
                this.Close(); // Close the form after successful registration
            }
            else
            {
                MessageBox.Show("Registration failed. Username might already exist.");
            }
        }
    }
}
