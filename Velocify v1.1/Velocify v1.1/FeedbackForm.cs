using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string feedback = textBox1.Text;

            if (string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Please enter some feedback before sending.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Set up the email message
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("velocify956@gmail.com"), // Your Gmail address
                    Subject = "User Feedback",
                    Body = feedback
                };

                mail.To.Add("lumendez956@gmail.com"); // Recipient's email

                // Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("velocify956@gmail.com", "qisb flfu tzuq tqtw"),
                    EnableSsl = true,
                };

                // Send the email
                smtpClient.Send(mail);
                MessageBox.Show("Feedback sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear(); // Clear the textbox after sending
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send feedback. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
