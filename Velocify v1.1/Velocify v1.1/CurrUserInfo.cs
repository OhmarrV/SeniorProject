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
    public partial class CurrUserInfo : Form
    {
        private int userId;
        public CurrUserInfo(int passedUserId)
        {
            InitializeComponent();
            DatabaseHandler db = new DatabaseHandler();
            string currUserName = db.FindUserName(passedUserId);

            userName.Text = currUserName;


        }

        private void userInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
