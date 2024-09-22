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
            SuspendLayout();
            // 
            // apiButton
            // 
            apiButton.Location = new Point(123, 375);
            apiButton.Name = "apiButton";
            apiButton.Size = new Size(75, 23);
            apiButton.TabIndex = 0;
            apiButton.Text = "button1";
            apiButton.UseVisualStyleBackColor = true;
            apiButton.Click += apiButton_Click;
            // 
            // txtGameData
            // 
            txtGameData.Location = new Point(86, 41);
            txtGameData.Multiline = true;
            txtGameData.Name = "txtGameData";
            txtGameData.Size = new Size(606, 298);
            txtGameData.TabIndex = 1;
            // 
            // APITestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGameData);
            Controls.Add(apiButton);
            Name = "APITestForm";
            Text = "APITestForm";
            Load += APITestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button apiButton;
        private TextBox txtGameData;
    }
}