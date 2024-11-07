namespace Velocify_v1._1
{
    partial class SettingSection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            indvSettingsPanel = new FlowLayoutPanel();
            sectionNameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(indvSettingsPanel);
            panel1.Controls.Add(sectionNameLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 427);
            panel1.TabIndex = 0;
            // 
            // indvSettingsPanel
            // 
            indvSettingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            indvSettingsPanel.AutoScroll = true;
            indvSettingsPanel.BackColor = SystemColors.ControlLight;
            indvSettingsPanel.Location = new Point(9, 57);
            indvSettingsPanel.Margin = new Padding(3, 4, 3, 4);
            indvSettingsPanel.Name = "indvSettingsPanel";
            indvSettingsPanel.Size = new Size(475, 339);
            indvSettingsPanel.TabIndex = 2;
            // 
            // sectionNameLabel
            // 
            sectionNameLabel.AutoSize = true;
            sectionNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionNameLabel.Location = new Point(9, 11);
            sectionNameLabel.Name = "sectionNameLabel";
            sectionNameLabel.Size = new Size(218, 41);
            sectionNameLabel.TabIndex = 0;
            sectionNameLabel.Text = "Setting Section";
            // 
            // SettingSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingSection";
            Size = new Size(494, 427);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel indvSettingsPanel;
        private Label sectionNameLabel;
    }
}
