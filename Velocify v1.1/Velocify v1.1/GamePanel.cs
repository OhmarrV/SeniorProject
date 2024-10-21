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
            UserControl gamePanel = new GamePanel();
            //string gId = gamePanel.Controls["settingsBtn"].Tag as string; //WORKING HERE 10/16 NOT WORKING
            SearchForGames searchForm = new SearchForGames();
            string gId = searchForm.SelectedGameId;
            MessageBox.Show("ID: " + gId);

            //MessageBox.Show("Gamezzz ID: " + gId);

            Form1 form1 = (Form1)this.FindForm();

            form1.change_Panel();//Pass into change_Panel(GAME_ID) 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings button");
        }

        
    }
}
