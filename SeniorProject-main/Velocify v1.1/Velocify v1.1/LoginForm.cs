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
        private string username1 = "user1";
        private string password1 = "Pass1";

        private string username2;
        private string password2;
        private int currUser2;

        private int currUser; //user id is stored here
        public LoginForm()
        {
            InitializeComponent();

            DatabaseHelper db = new DatabaseHelper();

            using (SQLiteDataReader reader = db.GetUserInfo())
            { 
                while(reader.Read())
                {
                    username2 = reader["username"].ToString();
                    password2 = reader["password"].ToString();
                    currUser2 = Convert.ToInt32(reader["id"]);
                }

            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            //if ((username1 == usernameTextBox.Text.ToLower() && password1 == passwordTextBox.Text)||(username2 == usernameTextBox.Text.ToLower() && password2 == passwordTextBox.Text))
            //{
            //    currUser = 1;

            //    MessageBox.Show("LOGIN SUCCESSFUL: \nUser: "+username2+"   Password: "+password2+"   ID: "+currUser2);
            //    //load form1
            //    Form1 form1 = new Form1();
            //    form1.Show();
            //    this.Hide();


            //}
            //else
            //{
            //    MessageBox.Show("LOGIN FAILED");
            //}
        }



    }
}
