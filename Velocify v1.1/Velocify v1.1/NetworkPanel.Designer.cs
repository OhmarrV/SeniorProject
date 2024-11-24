namespace Velocify_v1._1
{
    partial class NetworkPanel
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
            netPanel = new Panel();
            statusLabel = new Label();
            latencyLabel = new Label();
            netPanel.SuspendLayout();
            SuspendLayout();
            // 
            // netPanel
            // 
            netPanel.BackColor = Color.Maroon;
            netPanel.Controls.Add(statusLabel);
            netPanel.Controls.Add(latencyLabel);
            netPanel.Location = new Point(0, 0);
            netPanel.Name = "netPanel";
            netPanel.Size = new Size(359, 353);
            netPanel.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(28, 157);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(140, 20);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "MORE Network Info";
            // 
            // latencyLabel
            // 
            latencyLabel.AutoSize = true;
            latencyLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            latencyLabel.Location = new Point(28, 31);
            latencyLabel.Name = "latencyLabel";
            latencyLabel.Size = new Size(191, 41);
            latencyLabel.TabIndex = 0;
            latencyLabel.Text = "Network Info";
            latencyLabel.Click += latencyLabel_Click;
            // 
            // NetworkPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(netPanel);
            Name = "NetworkPanel";
            Size = new Size(359, 353);
            netPanel.ResumeLayout(false);
            netPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel netPanel;
        private Label statusLabel;
        private Label latencyLabel;
    }
}
