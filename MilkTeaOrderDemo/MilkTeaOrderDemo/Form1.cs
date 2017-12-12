using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMenu.Height;
            SidePanel.Top = btnMenu.Top;

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAbout.Height;
            SidePanel.Top = btnAbout.Top;
            aboutForm1.BringToFront();

        }

        private void btnESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
