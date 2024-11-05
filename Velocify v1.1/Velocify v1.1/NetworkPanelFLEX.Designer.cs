namespace Velocify_v1._1
{
    partial class NetworkPanelFLEX
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
            networkLibraryPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // networkLibraryPanel
            // 
            networkLibraryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            networkLibraryPanel.AutoScroll = true;
            networkLibraryPanel.BackColor = SystemColors.ButtonFace;
            networkLibraryPanel.Location = new Point(0, 0);
            networkLibraryPanel.Margin = new Padding(3, 4, 3, 4);
            networkLibraryPanel.Name = "networkLibraryPanel";
            networkLibraryPanel.Size = new Size(743, 527);
            networkLibraryPanel.TabIndex = 6;
            // 
            // NetworkPanelFLEX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(networkLibraryPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NetworkPanelFLEX";
            Size = new Size(743, 527);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel networkLibraryPanel;
    }
}
