using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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

        private async void speedTestBtn_Click(object sender, EventArgs e)
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
        private string serverAddress = ""; // Target server for ping tests    steampowered.com , store.epicgames.com , status.playstation.com , store.xbox.com , support.activision.com
        private void pingBtn_Click_1(object sender, EventArgs e)
        {
            if (servicesComboBox.Text == "" || servicesComboBox.Text == null)
            {
                MessageBox.Show("Please select a service to ping.");
                return;
            }
            if (servicesComboBox.Text == "Xbox")
            {
                serverAddress = "store.xbox.com";
                serviceLabel.Text = "Service: Xbox";
            }
            else if (servicesComboBox.Text == "PlayStation")
            {
                serverAddress = "status.playstation.com";
                serviceLabel.Text = "Service: PlayStation";
            }
            else if (servicesComboBox.Text == "Steam")
            {
                serverAddress = "steampowered.com";
                serviceLabel.Text = "Service: Steam";
            }
            else if (servicesComboBox.Text == "Epic Games")
            {
                serverAddress = "store.epicgames.com";
                serviceLabel.Text = "Service: Epic Games";
            }
            else if (servicesComboBox.Text == "Activision")
            {
                serverAddress = "support.activision.com";
                serviceLabel.Text = "Service: Activision";
            }
            else
            {
                serverAddress = "support.activision.com";
            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        //private System.Windows.Forms.Timer packetLossTimer2;
        //private int totalPackets = 300; // Total packets to send
        private int packetsSent = 0;
        private int packetsFailed = 0;
        private double totalLatency = 0;
        private double previousLatency = 0;
        private double totalJitter = 0;
        //private string serverAddress2 = "1.1.1.1"; // Target server for monitoring

        private async void button2_Click_1(object sender, EventArgs e)
        {
            packetsSent = 0;
            packetsFailed = 0;
            totalLatency = 0;
            totalJitter = 0;
            previousLatency = 0;

            string host = "google.com"; // Target host to ping
            int pingAmount = 150;       // Number of pings to send
            int timeout = 50;           // Timeout for each ping (in milliseconds)

            var failedPings = 0;
            var successfulPings = 0;
            var latencySum = 0;

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // 32 bytes of data
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            for (int i = 0; i < pingAmount; i++)
            {
                PingReply reply = await Task.Run(() => pingSender.Send(host, timeout, buffer, options));

                if (reply != null && reply.Status == IPStatus.Success)
                {
                    int currentLatency = (int)reply.RoundtripTime;
                    latencySum += currentLatency;
                    successfulPings++;

                    // Calculate jitter (variation in latency)
                    if (previousLatency > 0)
                    {
                        totalJitter += Math.Abs(currentLatency - previousLatency);
                    }
                    previousLatency = currentLatency;
                }
                else
                {
                    failedPings++;
                }

                // Update the labels dynamically
                pingLabel.Text = $"Ping {i + 1}: {reply.Status}";
                packetLabel.Text = $"Packet Loss: {(failedPings * 100) / (i + 1)}%";

                // Optional: Add a small delay to make the updates more visible
                await Task.Delay(50);
            }

            // Final updates
            int averagePing = successfulPings > 0 ? latencySum / successfulPings : 0;
            int packetLoss = (failedPings * 100) / pingAmount;
            double averageJitter = successfulPings > 1 ? totalJitter / (successfulPings - 1) : 0;

            pingLabel.Text = $"Final Avg Ping: {averagePing} ms";
            packetLabel.Text = $"Final Packet Loss: {packetLoss}%";
            jitterLabel.Text = $"Jitter: {averageJitter:F2} ms";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}

