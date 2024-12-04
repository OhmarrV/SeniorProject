using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocify_v1._1
{
    public partial class GamingScan : Form
    {
        public GamingScan(string url)
        {
            InitializeComponent();
            webView21.Source = new Uri(url);
        }
    }
}
