namespace Velocify_v1._1
{
    partial class FeedbackForm
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
            textBox1 = new TextBox();
            sendButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 159);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(710, 266);
            textBox1.TabIndex = 0;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(634, 110);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(112, 34);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 45);
            label1.Name = "label1";
            label1.Size = new Size(497, 25);
            label1.TabIndex = 2;
            label1.Text = "Please submit any problems or feedback in the message box.";
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(sendButton);
            Controls.Add(textBox1);
            Name = "FeedbackForm";
            Text = "FeedbackForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button sendButton;
        private Label label1;
    }
}