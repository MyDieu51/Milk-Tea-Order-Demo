using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    class OrderManagement
    {
        protected InvoiceCtrl invoiceCtrl;
        public FoodCtrl foodCtrl;

        public OrderManagement()
        {
            foodCtrl = new FoodCtrl();
            invoiceCtrl = new InvoiceCtrl(foodCtrl);
        }

        public void InputOrder(FoodModel food, DataGridView dgvListOrder)
        {
            invoiceCtrl.CreateReceiptDetailInfo(food, 1, dgvListOrder);
        }
    }
}
