using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public partial class MenuForm : UserControl
    {
        OrderManagement orderCtrl = new OrderManagement();

        public MenuForm()
        {
            InitializeComponent();
            LoadMenu();
            LoadTime();
        }

        private void LoadMenu()
        {
            List<FoodModel> listFood = orderCtrl.foodCtrl.ListFoods;
            List<Menu> listMenu = new List<Menu>();
            for (int i = 0; i < listFood.Count; i++)
            {
                listMenu.Add(new MilkTeaOrderDemo.Menu());
                listMenu[i].Location = new Point(20 + i % 4 * 170, 20 + i / 4 * 220);
                listMenu[i].Name = "menu" + i;
                listMenu[i].Size = new Size(150, 200);
                listMenu[i].TabIndex = 6;
                listMenu[i].LoadInfo(listFood[i]);
                panMenu.Controls.Add(listMenu[i]);
                listMenu[i].PicDoubleClick += UpdateOrder;
            }
        }

        private void LoadTime()
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void UpdateOrder(object sender, EventArgs e, FoodModel food)
        {
            orderCtrl.InputOrder(food, dgvOrder);
        }
    }
}
