using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string currGameName;
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
        }

        private void CreateSettingSection(string settingSectionName)
        {
            // Create a new SettingSection instance
            SettingSection settingSectionPanel = new SettingSection();
            settingSectionPanel.Dock = DockStyle.Top;

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
            settingSectionPanel.Size = new Size(700, 280); // Adjust size if needed
            //settingSectionPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            settingSectionPanel.SetSectionName(settingSectionName);


            //settingSectionPanel.

            // Add the new SettingSection to the panel
            settingsPanel.Controls.Add(settingSectionPanel);

        }

        public void PCSettingSection()
        {
            // Create a new SettingSection instance
            SettingSection settingSectionPanel = new SettingSection();
            settingSectionPanel.PCSettingPanel("", "");
            settingSectionPanel.Dock = DockStyle.Top;


            // Set the location and size for the new top section
            settingSectionPanel.Location = new Point(3, 3);
            settingSectionPanel.Size = new Size(702, 400); // Adjust size if needed
            //settingSectionPanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            settingSectionPanel.SetSectionName("Current PC Specifications");

            // Shift down existing controls to make space at the top
            foreach (Control control in settingsPanel.Controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + settingSectionPanel.Height + 10);
            }

            settingsPanel.Controls.Add(settingSectionPanel);
            settingsPanel.Controls.SetChildIndex(settingSectionPanel, 0);
            
        }

        private bool specBtnClicked = false;
        private void specBtn_Click(object sender, EventArgs e)
        {
            if (!specBtnClicked)
            {
                PCSettingSection();
                specBtnClicked = true;
                //scroll to the bottom of settingsPanel to view the new section
                settingsPanel.VerticalScroll.Value = settingsPanel.VerticalScroll.Maximum;
            }
            else
            {
                MessageBox.Show("Already displaying computer specifications.");
            }
        }
    }
}
