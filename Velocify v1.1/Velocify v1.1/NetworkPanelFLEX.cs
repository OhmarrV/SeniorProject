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
    public partial class NetworkPanelFLEX : UserControl
    {
        public NetworkPanelFLEX()
        {
            InitializeComponent();

            //NetworkPanel networkPanel = new NetworkPanel();
            //networkLibraryPanel.Controls.Add(networkPanel);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            NetworkHelper networkHelper = new NetworkHelper();
            int iterations = 50; // Number of speed tests to run
            double totalSpeed = 0;

            label1.Text = "Calculating speed...";

            for (int i = 0; i < iterations; i++)
            {
                double speed = await Task.Run(() => networkHelper.CheckInternetSpeed()); // Run speed test in a separate thread
                totalSpeed += speed;

                label1.Text = $"Download Speed: {speed} Mbps"; // Update label1 with the current speed
                await Task.Delay(0030); // Wait for 1 second before the next test
            }

            double averageSpeed = Math.Round(totalSpeed / iterations, 2); // Calculate the average speed
            label1.Text = $"Average Speed: {averageSpeed} Mbps"; // Display the average speed
            MessageBox.Show($"Your average internet speed is {averageSpeed} Mbps");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            NetworkHelper networkHelper = new NetworkHelper();
            int iterations = 50; // Number of speed tests to run
            double totalUploadSpeed = 0;

            label2.Text = "Calculating upload speed...";

            for (int i = 0; i < iterations; i++)
            {
                // Measure upload speed
                double uploadSpeed = await Task.Run(() => networkHelper.CheckUploadSpeed());
                totalUploadSpeed += uploadSpeed;

                // Update the upload speed label with the current speed
                label2.Text = $"Upload Speed: {uploadSpeed} Mbps";

                await Task.Delay(100); // Wait for 100 milliseconds before the next test
            }

            // Calculate average upload speed
            double averageUploadSpeed = Math.Round(totalUploadSpeed / iterations, 2);

            // Display the average upload speed
            label2.Text = $"Average Upload Speed: {averageUploadSpeed} Mbps";
            MessageBox.Show($"Your average upload speed is {averageUploadSpeed} Mbps");
        }
    }
}
