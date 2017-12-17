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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            Inil();
            homeUserControl1.BringToFront();
        }

        public void Inil()
        {
            FoodCtrl foodCtrl = new FoodCtrl();
            menuForm1.Inil(foodCtrl);
            editFoodForm1.Inil(foodCtrl);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeUserControl1.BringToFront();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMenu.Height;
            SidePanel.Top = btnMenu.Top;
            menuForm1.LoadInfo();
            menuForm1.BringToFront();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            editFoodForm1.LoadMenu();
            editFoodForm1.BringToFront();
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
