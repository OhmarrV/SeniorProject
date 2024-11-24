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
            //AddSettingPanel("Graphics Card", gpu);
            SettingPanel settingPanel = new SettingPanel();
            settingPanel.SetPanelTextBig("Graphics Card", gpu);
            indvSettingsPanel.Controls.Add(settingPanel);

            // Processor
            string cpu = GetHardwareInfo("Win32_Processor", "Name");
            //AddSettingPanel("Processor", cpu);
            SettingPanel settingPanelCPU = new SettingPanel();
            settingPanelCPU.SetPanelTextBig2("Processor", cpu);
            indvSettingsPanel.Controls.Add(settingPanelCPU);

            // RAM
            string ram = GetHardwareInfo("Win32_PhysicalMemory", "Capacity");
            AddSettingPanel("Memory", FormatBytes(ram));

            // Display
            string display = GetDisplayInfo();
            AddSettingPanel("Display", display);
            //Storage
            List<string> storage = GetStorageInfo();
            foreach(string drive in storage)
            {
                AddSettingPanel("Storage", drive);
            }

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
            List<string> gpus = new List<string>();

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string gpuName = obj["Caption"]?.ToString();
                    string adapterRAM = obj["AdapterRAM"]?.ToString();

                    // Check if GPU name contains keywords like "NVIDIA" or "AMD" and exclude Intel
                    if (!string.IsNullOrEmpty(gpuName) && (gpuName.Contains("NVIDIA") || gpuName.Contains("AMD")))
                    {
                        gpus.Add(gpuName);
                    }
                }
            }

            // Return the first found dedicated GPU, or default message if none found
            return gpus.Count > 0 ? gpus[0] : "Dedicated GPU not found";
        }

        private string GetDisplayInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT CurrentHorizontalResolution, CurrentVerticalResolution, MaxRefreshRate FROM Win32_VideoController").Get())
            {
                return $"{obj["CurrentHorizontalResolution"]}x{obj["CurrentVerticalResolution"]} @ {obj["MaxRefreshRate"]}Hz";
            }
            return "Unknown";
        }

        private List<string> GetStorageInfo()
        {
            List<string> storageInfo = new List<string>();
            int driveNumber = 1;

            foreach (ManagementObject drive in new ManagementObjectSearcher("SELECT MediaType, Size FROM Win32_DiskDrive").Get())
            {
                string capacity = drive["Size"]?.ToString() ?? "Unknown";

                // Convert size to GB
                if (long.TryParse(capacity, out long byteCount))
                {
                    double gigabytes = byteCount / (1024 * 1024 * 1024);
                    storageInfo.Add($"Drive {driveNumber}: {gigabytes:F2} GB");
                }
                else
                {
                    storageInfo.Add($"Drive {driveNumber}: Unknown Size");
                }

                driveNumber++;
            }

            return storageInfo;
        }



    }
}
