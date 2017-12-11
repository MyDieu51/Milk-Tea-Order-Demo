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
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuButton.Height;
            SidePanel.Top = MenuButton.Top;

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DashboardButton.Height;
            SidePanel.Top = DashboardButton.Top;

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AboutButton.Height;
            SidePanel.Top = AboutButton.Top;

        }       
    }
}
