namespace Velocify_v1._1
{
    partial class LoadingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            loadingLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loadingLogo);
            panel1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 318);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(101, 259);
            label1.Name = "label1";
            label1.Size = new Size(288, 59);
            label1.TabIndex = 0;
            label1.Text = "Velocify";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // loadingLogo
            // 
            loadingLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingLogo.BackColor = Color.Transparent;
            loadingLogo.Image = Properties.Resources.velocify_logo_SOLO;
            loadingLogo.Location = new Point(89, 0);
            loadingLogo.Name = "loadingLogo";
            loadingLogo.Size = new Size(305, 256);
            loadingLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingLogo.TabIndex = 0;
            loadingLogo.TabStop = false;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(484, 320);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            Text = "LoadingForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadingLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox loadingLogo;
    }
}