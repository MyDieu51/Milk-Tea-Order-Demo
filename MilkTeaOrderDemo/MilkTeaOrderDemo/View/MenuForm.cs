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
        OrderCtrl orderCtrl = new OrderCtrl();

        public MenuForm()
        {
            InitializeComponent();
        }

        public void Inil(FoodCtrl foodCtrl)
        {
            orderCtrl.Inil(foodCtrl);
            LoadInfo();
        }

        public void LoadInfo()
        {
            List<Food> listFood = orderCtrl.foodCtrl.ListFoods;
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
                listMenu[i].PicClick += UpdateOrder;
            }
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void UpdateOrder(object sender, EventArgs e, Food food)
        {
            orderCtrl.InputOrder(food, dgvOrder, txtVAT, txtTotal);
        }              
        
        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (int.TryParse(dgvOrder.CurrentRow.Cells[e.ColumnIndex].Value.ToString(), out int newQty))
                {
                    orderCtrl.EditOrder(e.RowIndex, newQty, dgvOrder, txtVAT, txtTotal);
                }
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            orderCtrl.Confirm();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrder.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                orderCtrl.DeleteOrder(e.RowIndex, dgvOrder, txtVAT, txtTotal);
        }
    }
}
