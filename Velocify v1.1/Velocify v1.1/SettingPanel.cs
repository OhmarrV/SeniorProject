﻿using System;
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
    public partial class SettingPanel : UserControl
    {
        public SettingPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetPanelText(string panel1, string panel2)
        {
            label1.Text = panel1;
            label2.Text = panel2;
        }

        public void SetPanelTextBig(string panel1, string panel2)
        {
            label1.Text = panel1;
            label2.Text = panel2;
            label2.Height = 56;
        }

        public void SetPanelTextBig2(string panel1, string panel2)
        {

            label1.Text = panel1;
            label2.Location = new Point(3, 60);
            label2.Text = panel2;
            label2.Font = new Font(label2.Font.FontFamily, 8);
            label2.Height = 56;
        }

    }
}
