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
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            statusLabel = new Label();
            latencyLabel = new Label();
            pingBtn = new Button();
            label4 = new Label();
            networkLibraryPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // networkLibraryPanel
            // 
            networkLibraryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            networkLibraryPanel.AutoScroll = true;
            networkLibraryPanel.BackColor = SystemColors.ButtonFace;
            networkLibraryPanel.Controls.Add(panel1);
            networkLibraryPanel.Controls.Add(panel3);
            networkLibraryPanel.Location = new Point(0, 0);
            networkLibraryPanel.Name = "networkLibraryPanel";
            networkLibraryPanel.Size = new Size(650, 395);
            networkLibraryPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 196);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 12);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 3;
            label3.Text = "Internet Speed Test";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(83, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(135, 26);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(109, 139);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Run Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 0;
            label2.Text = "Upload Speed:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Download Speed:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(statusLabel);
            panel3.Controls.Add(latencyLabel);
            panel3.Controls.Add(pingBtn);
            panel3.Location = new Point(304, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 196);
            panel3.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(32, 58);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(76, 15);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Connected: -";
            // 
            // latencyLabel
            // 
            latencyLabel.AutoSize = true;
            latencyLabel.Location = new Point(32, 37);
            latencyLabel.Name = "latencyLabel";
            latencyLabel.Size = new Size(59, 15);
            latencyLabel.TabIndex = 4;
            latencyLabel.Text = "Latency: -";
            // 
            // pingBtn
            // 
            pingBtn.Location = new Point(206, 167);
            pingBtn.Margin = new Padding(3, 2, 3, 2);
            pingBtn.Name = "pingBtn";
            pingBtn.Size = new Size(82, 23);
            pingBtn.TabIndex = 3;
            pingBtn.Text = "Ping Servers";
            pingBtn.UseVisualStyleBackColor = true;
            pingBtn.Click += pingBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 14);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 6;
            label4.Text = "Google";
            // 
            // NetworkPanelFLEX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(networkLibraryPanel);
            Name = "NetworkPanelFLEX";
            Size = new Size(650, 395);
            networkLibraryPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel networkLibraryPanel;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Button pingBtn;
        private Label statusLabel;
        private Label latencyLabel;
        private Label label4;
    }
}
