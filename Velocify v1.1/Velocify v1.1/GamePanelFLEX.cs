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
using System.Xml.Linq;

namespace Velocify_v1._1
{
    public partial class GamePanelFLEX : UserControl
    {
        public GamePanelFLEX()
        {
            InitializeComponent();
        }

        private void gameAddButton1_Load(object sender, EventArgs e)
        {

        }

        //LOAD GAME PANEL ON LOG IN
        public void LoadUpGamePanel()
        {
            //q: why do we add the gamePanel to this.Parent?
            //a: we add the gamePanel to this.Parent to display the gamePanel on the form
            //q: what is this.Parent?
            //a: this.Parent is the parent control of the current control
            //q: what is the parent control of the GameAddButton?
            //a: the parent control of the GameAddButton is the GamePanel
            //q: why do we remove this from the parent controls?
            //a: we remove this from the parent controls to replace the GameAddButton with the GamePanel

            //replicate that here in this file
            //UserControl gamePanel = new GamePanel();
            //UserControl addNewGame = new GameAddButton();
            

        }

    }
}
