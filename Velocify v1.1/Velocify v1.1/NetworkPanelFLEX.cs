using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            double totalUploadSpeed = 0;

            label1.Text = "Calculating speed...";

            for (int i = 0; i < iterations; i++)
            {
                double speed = await Task.Run(() => networkHelper.CheckInternetSpeed()); // Run speed test in a separate thread
                totalSpeed += speed;

                label1.Text = $"Download Speed: {speed} Mbps"; // Update label1 with the current speed

                // Measure upload speed
                double uploadSpeed = await Task.Run(() => networkHelper.CheckUploadSpeed());
                totalUploadSpeed += uploadSpeed;



                // Update the upload speed label with the current speed
                label2.Text = $"Upload Speed: {uploadSpeed} Mbps";

                //await Task.Delay(100); // Wait for 100 milliseconds before the next test

                await Task.Delay(0030); // Wait for 1 second before the next test


            }

            // Calculate average upload speed
            double averageUploadSpeed = Math.Round(totalUploadSpeed / iterations, 2);

            // Display the average upload speed
            label2.Text = $"Upload Speed: {averageUploadSpeed} Mbps";

            double averageSpeed = Math.Round(totalSpeed / iterations, 2); // Calculate the average speed
            label1.Text = $"Download Speed: {averageSpeed} Mbps"; // Display the average speed
            MessageBox.Show("Speed Test Completed");
        }




        private System.Windows.Forms.Timer pingTimer;
        private string serverAddress = "google.com"; // Target server for ping tests
        private void pingBtn_Click(object sender, EventArgs e)
        {
            // Initialize the timer for periodic ping checks
            pingTimer = new System.Windows.Forms.Timer { Interval = 3000 }; // Ping every 3 seconds
            pingTimer.Tick += PingServer;
            pingTimer.Start();
        }

        private void PingServer(object sender, EventArgs e)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(serverAddress);

                    if (reply.Status == IPStatus.Success)
                    {
                        latencyLabel.Text = $"Latency: {reply.RoundtripTime} ms";
                        statusLabel.Text = "Status: Connected";

                        // Check for high latency
                        if (reply.RoundtripTime > 100)
                        {
                            statusLabel.Text = "Status: Slow Connection";
                        }
                    }
                    else
                    {
                        latencyLabel.Text = "Latency: - ms";
                        statusLabel.Text = "Status: Disconnected";
                    }
                }
            }
            catch (Exception ex)
            {
                latencyLabel.Text = "Latency: - ms";
                statusLabel.Text = $"Status: Error ({ex.Message})";
            }
        }
    }


}

