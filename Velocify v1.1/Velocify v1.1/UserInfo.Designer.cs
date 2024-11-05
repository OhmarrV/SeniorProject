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
            userProfilePic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userProfilePic.BackgroundImageLayout = ImageLayout.Center;
            userProfilePic.Cursor = Cursors.Hand;
            userProfilePic.Image = Properties.Resources.userIcon;
            userProfilePic.Location = new Point(0, 0);
            userProfilePic.Margin = new Padding(3, 4, 3, 4);
            userProfilePic.Name = "userProfilePic";
            userProfilePic.Size = new Size(589, 687);
            userProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            userProfilePic.TabIndex = 0;
            userProfilePic.TabStop = false;
            userProfilePic.Click += userProfilePic_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(userProfilePic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserInfo";
            Size = new Size(589, 687);
            ((System.ComponentModel.ISupportInitialize)userProfilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox userProfilePic;
    }
}
