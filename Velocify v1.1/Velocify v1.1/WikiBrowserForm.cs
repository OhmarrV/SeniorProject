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
    public partial class WikiBrowserForm : Form
    {
        public WikiBrowserForm(string url)
        {
            InitializeComponent();
            webView21.Source = new Uri(url); // webView2 is the WebView2 control
        }
    }
}
