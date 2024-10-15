namespace Velocify_v1._1
{
    partial class APITestForm
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
            apiButton = new Button();
            txtGameData = new TextBox();
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // apiButton
            // 
            apiButton.Location = new Point(141, 500);
            apiButton.Margin = new Padding(3, 4, 3, 4);
            apiButton.Name = "apiButton";
            apiButton.Size = new Size(86, 31);
            apiButton.TabIndex = 0;
            apiButton.Text = "button1";
            apiButton.UseVisualStyleBackColor = true;
            apiButton.Click += apiButton_Click;
            // 
            // txtGameData
            // 
            txtGameData.Location = new Point(98, 55);
            txtGameData.Margin = new Padding(3, 4, 3, 4);
            txtGameData.Multiline = true;
            txtGameData.Name = "txtGameData";
            txtGameData.Size = new Size(692, 145);
            txtGameData.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(320, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(41, 500);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 3;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // APITestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtGameData);
            Controls.Add(apiButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "APITestForm";
            Text = "APITestForm";
            Load += APITestForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button apiButton;
        private TextBox txtGameData;
        private PictureBox pictureBox1;
        private Button backBtn;
    }
}