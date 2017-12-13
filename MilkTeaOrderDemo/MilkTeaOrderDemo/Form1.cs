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
            panMenuForm.BringToFront();
            LoadMenu();
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
        }

        private void btnESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadMenu()
        {
            List<FoodModel> listFood = new List<FoodModel>();
            FoodModel food1 = new FoodModel("Bibimbap", 45000, 30000, "..\\..\\pic\\Bibimbap.png");
            FoodModel food2 = new FoodModel("Kimchi", 15000, 10000, "..\\..\\pic\\Kimchi.png");
            FoodModel food3 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            FoodModel food4 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            FoodModel food5 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            FoodModel food6 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            listFood.Add(food1);
            listFood.Add(food2);
            listFood.Add(food3);
            listFood.Add(food4);
            listFood.Add(food2);
            for (int i = 0; i < listFood.Count; i++)
            {
                Menu menu = new MilkTeaOrderDemo.Menu();
                menu.Location = new System.Drawing.Point(20 + i % 4 * 170, 20 + i / 4 * 220);
                menu.Name = "menu" + i;
                menu.Size = new System.Drawing.Size(150, 200);
                menu.TabIndex = 6;
                menu.LoadInfo(listFood[i]);
                panMenu.Controls.Add(menu);
            }
        }
    }
}
