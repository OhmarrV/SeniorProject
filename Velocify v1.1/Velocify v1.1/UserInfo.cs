using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void userProfilePic_Click(object sender, EventArgs e)
        {
            ToolStripDropDown dropDownMenu = new ToolStripDropDown();

            ToolStripMenuItem accountSettings = new ToolStripMenuItem("Account Settings");
            ToolStripMenuItem signOut = new ToolStripMenuItem("Sign Out");

            // Add click events to the items
            signOut.Click += SignOut_Click;
            accountSettings.Click += AccountSettings_Click;

            // Add the items to the ToolStripDropDown
            dropDownMenu.Items.Add(accountSettings);
            dropDownMenu.Items.Add(signOut);

            // Show the drop-down menu at the button's location
            dropDownMenu.Show(userProfilePic, new System.Drawing.Point(0, userProfilePic.Height));
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            db.ClearAllSessionTokens();
            Application.Restart();
        }
        

        private void AccountSettings_Click(object sender, EventArgs e)
        {
            int userId = (int)this.Tag;
            CurrUserInfo userInfo = new CurrUserInfo(userId);
            userInfo.Show();
        }
    }
}
