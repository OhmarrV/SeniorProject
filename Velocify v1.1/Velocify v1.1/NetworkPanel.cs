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
    public partial class NetworkPanel : UserControl
    {
        private System.Windows.Forms.Timer pingTimer;
        private string serverAddress = "google.com"; // Target server for ping tests
        public NetworkPanel()
        {
            // Initialize the timer for periodic ping checks
            pingTimer = new System.Windows.Forms.Timer { Interval = 3000 }; // Ping every 3 seconds
            pingTimer.Tick += PingServer;
            pingTimer.Start();
            InitializeComponent();
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
