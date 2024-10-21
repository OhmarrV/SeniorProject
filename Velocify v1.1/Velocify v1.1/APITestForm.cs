using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocify_v1._1;

namespace Velocify_v1._1
{
    public partial class APITestForm : Form
    {
        public APITestForm()
        {
            InitializeComponent();
        }

        private void APITestForm_Load(object sender, EventArgs e)
        {

        }

        private async void apiButton_Click(object sender, EventArgs e)
        {
            //// Clear the TextBox before fetching new data
            //txtGameData.Clear();

            //// Get the game name from a TextBox or set it directly
            //string gameName = "Overwatch 2"; // You can replace this with a TextBox input if needed

            //// Call the API method to fetch game data
            //string gameData = await APIFile.GetGameDataAsync(gameName);

            //// Display the fetched data in the TextBox
            //txtGameData.Text = gameData;



            // Clear the TextBox before fetching new data
            txtGameData.Clear();

            // Get the game ID from a TextBox or set it directly
            string gameId = "125174";
            //if (!int.TryParse(txtGameData.Text, out gameId))
            //{
            //    txtGameData.Text = "Please enter a valid game ID.";
            //    return;
            //}

            // Call the API method to fetch game data by ID
            string gameData = await APIFile.GetGameByIdAsync(gameId);

            // Display the fetched data in the TextBox
            txtGameData.Text = gameData;

            //grab the cover URL from the JSON response
            string coverUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big/co885f.jpg";
            MessageBox.Show(coverUrl);

            pictureBox1.Load(coverUrl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            int currUserId = Form1.currUserId;

            Form1 mainForm = new Form1(currUserId);
            mainForm.Show();
            this.Hide();
        }
    }
}
