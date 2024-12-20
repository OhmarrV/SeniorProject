﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            //MakeRoundedPictureBox(pictureBoxGame, 10);
            ResizeTimer_Tick(null, null);

            resizeTimer = new System.Windows.Forms.Timer();
            resizeTimer.Interval = 2;
            resizeTimer.Tick += ResizeTimer_Tick;
        }

        private void pictureBoxGame_Click(object sender, EventArgs e)
        {

            string gId = this.Controls["settingsBtn"].Tag.ToString();
            MessageBox.Show("GamePanel.cs ID: " + gId);

            Form1 form1 = (Form1)this.FindForm();

            form1.change_Panel(gId);//Pass into change_Panel(GAME_ID) 
        }


        //Variables for resizing the picture box
        private System.Windows.Forms.Timer resizeTimer;
        private int incrementCount = 0;
        private int maxIncrement = 4;
        private bool isHovering = true;
        private void pictureBoxGame_MouseEnter(object sender, EventArgs e)
        {
            Debug.WriteLine("Mouse Enter");
            isHovering = true;
            incrementCount = 0;
            resizeTimer.Start();
        }

        private void pictureBoxGame_MouseLeave(object sender, EventArgs e)
        {
            Debug.WriteLine("Mouse Leave");

            incrementCount = 0;
            isHovering = false;
            resizeTimer.Start();
        }

        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            if (isHovering && incrementCount < maxIncrement)
            {
                pictureBoxGame.Size = new Size(pictureBoxGame.Width + 1, pictureBoxGame.Height + 1);
                //MessageBox.Show(this.Name);
                MakeRoundedPictureBox(pictureBoxGame, 10);
                this.Controls["labelGame"].Size = new Size(168, 53);
                this.Controls["settingsDots"].Size = new Size(55, 58);
                incrementCount++;
            }
            else if (!isHovering && incrementCount < maxIncrement)
            {
                pictureBoxGame.Size = new Size(pictureBoxGame.Width - 1, pictureBoxGame.Height - 1);
                MakeRoundedPictureBox(pictureBoxGame, 10);
                this.Controls["labelGame"].Size = new Size(166, 51);
                this.Controls["settingsDots"].Size = new Size(53, 56);
                incrementCount++;
            }
            else
            {
                resizeTimer.Stop();
            }
        }



        private void settingsBtn_Click(object sender, EventArgs e)
        {
            // Create a new ToolStripDropDown
            ToolStripDropDown dropDownMenu = new ToolStripDropDown();

            // Create "Remove" menu item
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove");


            // Add click events to the items
            removeItem.Click += RemovePanel;

            // Add the items to the ToolStripDropDown
            dropDownMenu.Items.Add(removeItem);


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


        public void MakeRoundedPictureBox(PictureBox pictureBox, int cornerRadius)
        {
            // Create a graphics path for a rounded rectangle
            GraphicsPath path = new GraphicsPath();
            int diameter = cornerRadius * 2;

            // Add rounded rectangle corners
            path.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);
            path.AddArc(new Rectangle(pictureBox.Width - diameter, 0, diameter, diameter), 270, 90);
            path.AddArc(new Rectangle(pictureBox.Width - diameter, pictureBox.Height - diameter, diameter, diameter), 0, 90);
            path.AddArc(new Rectangle(0, pictureBox.Height - diameter, diameter, diameter), 90, 90);
            path.CloseAllFigures();

            // Set the region of the PictureBox to the rounded rectangle path
            pictureBox.Region = new Region(path);
        }



    }
}
