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

        private void OptionButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnOption.Height;
            SidePanel.Top = btnOption.Top;
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Control_KeyUp (object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                this.SelectNextControl((UserControl)sender, true, false, true, true);
            }
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((UserControl)sender, false, false, true, true);
            }
        }
    }
}
