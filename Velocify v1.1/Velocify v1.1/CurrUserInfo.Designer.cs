namespace Velocify_v1._1
{
    partial class CurrUserInfo
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
            userName = new Label();
            userInfo1 = new UserInfo();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Agency FB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userName.ForeColor = SystemColors.Control;
            userName.Location = new Point(91, 36);
            userName.Name = "userName";
            userName.Size = new Size(131, 39);
            userName.TabIndex = 0;
            userName.Text = "User Name";
            // 
            // userInfo1
            // 
            userInfo1.BackColor = Color.Transparent;
            userInfo1.Enabled = false;
            userInfo1.Location = new Point(11, 11);
            userInfo1.Name = "userInfo1";
            userInfo1.Size = new Size(74, 62);
            userInfo1.TabIndex = 1;
            userInfo1.Load += userInfo1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(userName);
            panel1.Controls.Add(userInfo1);
            panel1.Location = new Point(-1, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 85);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(10, 124);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(10, 199);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // CurrUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(509, 265);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CurrUserInfo";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Account Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userName;
        private UserInfo userInfo1;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}