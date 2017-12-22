using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    class InvoiceDetail
    {
        public static int ID;
        public int idInvoice, qtyProduct, total;
        public Food food;

        public string FoodName { get => food.Name; }

        public int Quantity { get => qtyProduct; set => qtyProduct = value; }

        public int Total { get => total; set => total = value; }

        public InvoiceDetail()
        {

        }

        public InvoiceDetail(Food food, int qtyFood)
        {
            this.idInvoice = ++ID;
            this.food = food;
            this.qtyProduct = qtyFood;
            this.total = food.Price * qtyFood;
        }

    }
}
