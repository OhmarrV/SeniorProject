using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class GamePanel : UserControl
    {

        public GamePanel()
        {
            InitializeComponent();
        }

        public string GameName
        {
            get => labelGame.Text;
            set => labelGame.Text = value;
        }

        public string CoverUrl
        {
            get => pictureBox1.ImageLocation;
            set
            {
                if (Uri.IsWellFormedUriString(value, UriKind.Absolute))
                {
                    pictureBox1.ImageLocation = value; // Set the image URL

                    try
                    {
                        pictureBox1.Load(); // Attempt to load the image
                    }
                    catch (Exception ex)
                    {
                        // Handle loading error
                        Console.WriteLine($"Error loading image: {ex.Message}");
                        // Convert byte array to Image
                        using (var ms = new System.IO.MemoryStream(Properties.Resources.PlaceHolderImage))
                        {
                            pictureBox1.Image = Image.FromStream(ms); // Set the placeholder image
                        }
                    }
                }
                else
                {
                    // Handle invalid URL scenario
                    Console.WriteLine("Invalid image URL.");
                    // Convert byte array to Image
                    using (var ms = new System.IO.MemoryStream(Properties.Resources.PlaceHolderImage))
                    {
                        pictureBox1.Image = Image.FromStream(ms); // Set the placeholder image
                    }
                }
            }
        }

    }
}
