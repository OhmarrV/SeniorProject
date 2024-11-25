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
            panel5 = new Panel();
            panel9 = new Panel();
            panel2 = new Panel();
            label13 = new Label();
            pingLabel = new Label();
            packetLabel = new Label();
            jitterLabel = new Label();
            button2 = new Button();
            panel8 = new Panel();
            panel1 = new Panel();
            serviceLabel = new Label();
            servicesComboBox = new ComboBox();
            statusLabel = new Label();
            latencyLabel = new Label();
            pingBtn = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            speedTestBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(644, 389);
            panel5.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = SystemColors.ControlLight;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(pingLabel);
            panel9.Controls.Add(packetLabel);
            panel9.Controls.Add(jitterLabel);
            panel9.Controls.Add(button2);
            panel9.Location = new Point(27, 212);
            panel9.Name = "panel9";
            panel9.Size = new Size(596, 174);
            panel9.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label13);
            panel2.Location = new Point(9, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 37);
            panel2.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(7, 3);
            label13.Name = "label13";
            label13.Size = new Size(147, 28);
            label13.TabIndex = 1;
            label13.Text = "Packet Loss";
            // 
            // pingLabel
            // 
            pingLabel.AutoSize = true;
            pingLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            pingLabel.Location = new Point(9, 75);
            pingLabel.Name = "pingLabel";
            pingLabel.Size = new Size(58, 19);
            pingLabel.TabIndex = 4;
            pingLabel.Text = "Ping: -";
            // 
            // packetLabel
            // 
            packetLabel.AutoSize = true;
            packetLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            packetLabel.Location = new Point(227, 75);
            packetLabel.Name = "packetLabel";
            packetLabel.Size = new Size(110, 19);
            packetLabel.TabIndex = 3;
            packetLabel.Text = "Packet Loss: -";
            // 
            // jitterLabel
            // 
            jitterLabel.AutoSize = true;
            jitterLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            jitterLabel.Location = new Point(462, 75);
            jitterLabel.Name = "jitterLabel";
            jitterLabel.Size = new Size(59, 19);
            jitterLabel.TabIndex = 2;
            jitterLabel.Text = "Jitter: -";
            // 
            // button2
            // 
            button2.Location = new Point(245, 144);
            button2.Name = "button2";
            button2.Size = new Size(74, 23);
            button2.TabIndex = 0;
            button2.Text = "Start Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.BackColor = SystemColors.ControlLight;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(servicesComboBox);
            panel8.Controls.Add(statusLabel);
            panel8.Controls.Add(latencyLabel);
            panel8.Controls.Add(pingBtn);
            panel8.Location = new Point(332, 12);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(295, 196);
            panel8.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(serviceLabel);
            panel1.Location = new Point(146, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 26);
            panel1.TabIndex = 8;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceLabel.Location = new Point(14, 3);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(103, 19);
            serviceLabel.TabIndex = 6;
            serviceLabel.Text = "Ping Service";
            // 
            // servicesComboBox
            // 
            servicesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            servicesComboBox.FormattingEnabled = true;
            servicesComboBox.Items.AddRange(new object[] { "Xbox", "PlayStation", "Steam", "Epic Games", "Activision" });
            servicesComboBox.Location = new Point(11, 13);
            servicesComboBox.Name = "servicesComboBox";
            servicesComboBox.Size = new Size(121, 23);
            servicesComboBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            statusLabel.Location = new Point(146, 124);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(84, 16);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Connected: -";
            // 
            // latencyLabel
            // 
            latencyLabel.AutoSize = true;
            latencyLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            latencyLabel.Location = new Point(146, 71);
            latencyLabel.Name = "latencyLabel";
            latencyLabel.Size = new Size(64, 16);
            latencyLabel.TabIndex = 4;
            latencyLabel.Text = "Latency: -";
            // 
            // pingBtn
            // 
            pingBtn.Location = new Point(172, 167);
            pingBtn.Margin = new Padding(3, 2, 3, 2);
            pingBtn.Name = "pingBtn";
            pingBtn.Size = new Size(82, 23);
            pingBtn.TabIndex = 3;
            pingBtn.Text = "Ping Servers";
            pingBtn.UseVisualStyleBackColor = true;
            pingBtn.Click += pingBtn_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLight;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(speedTestBtn);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(16, 12);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 196);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label3);
            panel7.Location = new Point(83, 7);
            panel7.Name = "panel7";
            panel7.Size = new Size(135, 26);
            panel7.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(133, 16);
            label3.TabIndex = 7;
            label3.Text = "Internet Speed Test ";
            label3.Click += label3_Click;
            // 
            // speedTestBtn
            // 
            speedTestBtn.Location = new Point(109, 139);
            speedTestBtn.Margin = new Padding(3, 2, 3, 2);
            speedTestBtn.Name = "speedTestBtn";
            speedTestBtn.Size = new Size(82, 22);
            speedTestBtn.TabIndex = 2;
            speedTestBtn.Text = "Run Test";
            speedTestBtn.UseVisualStyleBackColor = true;
            speedTestBtn.Click += speedTestBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 0;
            label2.Text = "Upload Speed:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 0;
            label1.Text = "Download Speed:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NetworkPanelFLEX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel5);
            Name = "NetworkPanelFLEX";
            Size = new Size(650, 395);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel9;
        private Label pingLabel;
        private Label packetLabel;
        private Label jitterLabel;
        private Label label13;
        private Button button2;
        private Panel panel8;
        private ComboBox servicesComboBox;
        private Label serviceLabel;
        private Label statusLabel;
        private Label latencyLabel;
        private Button pingBtn;
        private Panel panel6;
        private Panel panel7;
        private Button speedTestBtn;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
    }
}
