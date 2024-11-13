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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            networkLibraryPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // networkLibraryPanel
            // 
            networkLibraryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            networkLibraryPanel.AutoScroll = true;
            networkLibraryPanel.BackColor = SystemColors.ButtonFace;
            networkLibraryPanel.Controls.Add(panel1);
            networkLibraryPanel.Controls.Add(panel2);
            networkLibraryPanel.Location = new Point(0, 0);
            networkLibraryPanel.Margin = new Padding(3, 4, 3, 4);
            networkLibraryPanel.Name = "networkLibraryPanel";
            networkLibraryPanel.Size = new Size(743, 527);
            networkLibraryPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 261);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(111, 57);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(54, 137);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 57);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(86, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(319, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 261);
            panel2.TabIndex = 3;
            // 
            // NetworkPanelFLEX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(networkLibraryPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NetworkPanelFLEX";
            Size = new Size(743, 527);
            networkLibraryPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel networkLibraryPanel;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Label label2;
    }
}
