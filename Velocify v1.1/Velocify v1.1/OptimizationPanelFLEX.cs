using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Velocify_v1._1
{
    public partial class OptimizationPanelFlex : UserControl
    {
        int currGameId;
        public string currGameName { get; set; }
        DatabaseHelper db = new DatabaseHelper();
        public OptimizationPanelFlex(string gameId)
        {
            currGameId = Convert.ToInt32(gameId);

            InitializeComponent();

            currGameName = db.GetGameName(currGameId);
            gameLabel.Text = currGameName;

            List<string> sections = db.GetUniqueSettingsSections(currGameName);

            //for each loop for settingsList
            foreach (var sectionName in sections)
            {
                CreateSettingSection(sectionName);
            }

            Wiki.Click += new EventHandler(button1_Click);
            button3.Click += new EventHandler(button3_Click);
        }

        private void GamingScan_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currGameName))
            {
                Debug.WriteLine($"Opening GamingScan page for: {currGameName}");
                try
                {
                    string url = $"https://www.gamingscan.com/best-settings-{Uri.EscapeDataString(currGameName.ToLower().Replace(" ", "-"))}/";
                    GamingScan gamingScan = new GamingScan(url);
                    gamingScan.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open link: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Game name is not set.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currGameName))
            {
                Debug.WriteLine($"Opening Wikipedia page for: {currGameName}");
                try
                {
                    string url = $"https://en.wikipedia.org/wiki/{Uri.EscapeDataString(currGameName)}";
                    WikiBrowserForm wikiBrowserForm = new WikiBrowserForm(url);
                    wikiBrowserForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open link: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Game name is not set.");
            }
        }

        private void CreateSettingSection(string settingSectionName)
        {
            // Create a new SettingSection instance
            SettingSection settingSectionPanel = new SettingSection();

            settingSectionPanel.PopulateSettings(currGameName, settingSectionName);


            // Calculate the Y position for the new SettingSection
            int newYPosition = 3;
            if (settingsPanel.Controls.Count > 0)
            {
                // Get the last added SettingSection and calculate the new position below it
                Control lastControl = settingsPanel.Controls[settingsPanel.Controls.Count - 1];
                newYPosition = lastControl.Bottom + 10; // Adjust the gap as needed
            }

            // Set the location and size
            settingSectionPanel.Location = new Point(3, newYPosition);
            settingSectionPanel.Size = new Size(650, 280); // Adjust size if needed
            settingSectionPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            settingSectionPanel.SetSectionName(settingSectionName);
            

            //settingSectionPanel.

            // Add the new SettingSection to the panel
            settingsPanel.Controls.Add(settingSectionPanel);
            
        }




    }
}
