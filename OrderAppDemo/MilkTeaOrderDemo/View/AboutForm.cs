using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MilkTeaOrderDemo
{
    public partial class AboutForm : UserControl
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/my.dieu.927");
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/minthanh34/");
        }
    }
}
