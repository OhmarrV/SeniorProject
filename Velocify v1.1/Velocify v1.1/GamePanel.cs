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
            //UserControl gamePanel = new GamePanel();
            //q: how to access the GamePanel settingsBtn control
            //a: create a public method in GamePanel that returns the settingsBtn control

            string gId = this.Controls["settingsBtn"].Tag.ToString();
            MessageBox.Show("GamePanel ID: " + gId);

            Form1 form1 = (Form1)this.FindForm();

            form1.change_Panel(gId);//Pass into change_Panel(GAME_ID) 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings button");
        }

        
    }
}
