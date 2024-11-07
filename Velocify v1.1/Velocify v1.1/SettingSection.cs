using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Management; 

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

        public void PCSettingPanel(string pcSpec, string specName)
        {
            //access the user's pc specs
            // Graphics Card
            string gpu = GetDetailedGraphicsCardInfo();
            AddSettingPanel("Graphics Card", gpu);

            // Processor
            string cpu = GetHardwareInfo("Win32_Processor", "Name");
            AddSettingPanel("Processor", cpu);
            // RAM
            string ram = GetHardwareInfo("Win32_PhysicalMemory", "Capacity");
            AddSettingPanel("Memory", FormatBytes(ram));

            //AddSettingPanel("Graphics Card", "Nvidia 1060");
        }

        private string GetHardwareInfo(string category, string property)
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT {property} FROM {category}");
            foreach (ManagementObject obj in searcher.Get())
            {
                result = obj[property]?.ToString();
                break; // Only return the first result
            }
            return result;
        }

        private string FormatBytes(string bytes)
        {
            if (long.TryParse(bytes, out long byteCount))
            {
                double gigabytes = byteCount / (1024 * 1024 * 1024);
                return $"{gigabytes:F2} GB";
            }
            return "Unknown";
        }

        private string GetDetailedGraphicsCardInfo()
        {
            string gpuName = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    gpuName = obj["Caption"]?.ToString();  // "Caption" sometimes has the full name
                    break;
                }
            }
            return gpuName;
        }
    }
}
