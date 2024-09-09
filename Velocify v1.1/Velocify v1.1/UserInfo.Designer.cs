namespace Velocify_v1._1
{
    partial class UserInfo
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
            userProfilePic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userProfilePic).BeginInit();
            SuspendLayout();
            // 
            // userProfilePic
            // 
            userProfilePic.AccessibleRole = AccessibleRole.PushButton;
            userProfilePic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userProfilePic.BackgroundImageLayout = ImageLayout.Center;
            userProfilePic.Cursor = Cursors.Hand;
            userProfilePic.Image = Properties.Resources.userIcon;
            userProfilePic.Location = new Point(0, 0);
            userProfilePic.Name = "userProfilePic";
            userProfilePic.Size = new Size(515, 515);
            userProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePic.TabIndex = 0;
            userProfilePic.TabStop = false;
            userProfilePic.Click += userProfilePic_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(userProfilePic);
            Name = "UserInfo";
            Size = new Size(515, 515);
            ((System.ComponentModel.ISupportInitialize)userProfilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox userProfilePic;
    }
}
