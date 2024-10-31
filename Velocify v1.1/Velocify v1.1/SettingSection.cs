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
    public partial class SettingSection : UserControl
    {
        DatabaseHelper db = new DatabaseHelper();
        public SettingSection()
        {
            InitializeComponent();
            //add a setting panel to indvSettingsPanel

            //AddSettingPanel();
        }

        public void SetSectionName(string sectionName)
        {
            sectionNameLabel.Text = sectionName;
        }

        public void SetSettingName()
        {

        }

        public void createSettingPanel()
        {
            //duplicate settingPanel

        }

        private void settingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void AddSettingPanel(string gameSetting, string settingValue)
        {
            SettingPanel settingPanel = new SettingPanel();
            settingPanel.SetPanelText(gameSetting, settingValue);
            indvSettingsPanel.Controls.Add(settingPanel);


        }

        // Method to populate the section with settings panels
        public void PopulateSettings(string gameName, string sectionName)
        {
            // Set the section name label
            SetSectionName(sectionName);

            // Fetch the settings from the database
            List<(string gameSetting, string settingValue)> settings = db.GetSettingsForSection(gameName, sectionName);

            // Add each setting to the panel
            foreach (var setting in settings)
            {
                AddSettingPanel(setting.gameSetting, setting.settingValue);
            }
        }
    }
}
