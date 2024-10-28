using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        private void pictureBoxGame_Click(object sender, EventArgs e)
        {

            string gId = this.Controls["settingsBtn"].Tag.ToString();
            MessageBox.Show("GamePanel.cs ID: " + gId);

            Form1 form1 = (Form1)this.FindForm();

            form1.change_Panel(gId);//Pass into change_Panel(GAME_ID) 
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            // Create a new ToolStripDropDown
            ToolStripDropDown dropDownMenu = new ToolStripDropDown();

            // Create "Remove" and "Move" menu items
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");
            ToolStripMenuItem moveItem = new ToolStripMenuItem("Move");

            // Add click events to the items
            removeItem.Click += RemovePanel;
            //moveItem.Click += MoveItem_Click;

            // Add the items to the ToolStripDropDown
            dropDownMenu.Items.Add(removeItem);
            dropDownMenu.Items.Add(moveItem);

            // Show the drop-down menu at the button's location
            dropDownMenu.Show(settingsBtn, new System.Drawing.Point(0, settingsBtn.Height));
        }

        private void RemovePanel(object sender, EventArgs e)
        {
            //MessageBox.Show("DELETING USER: "+ Form1.currUserId+ ", DELETING GAME ID: " + this.Controls["settingsBtn"].Tag.ToString());
            this.Parent.Controls.Remove(this);

            DatabaseHandler db = new DatabaseHandler();
            db.DeleteGameFromUser(Form1.currUserId, this.Controls["settingsBtn"].Tag.ToString());
        }


    }
}
