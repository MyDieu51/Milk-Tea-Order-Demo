﻿using System;
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
        public FoodModel food;

        public InvoiceDetail()
        {

        }

        public InvoiceDetail(FoodModel food, int qtyFood)
        {
            this.idInvoice = ++ID;
            this.food = food;
            this.qtyProduct = qtyFood;
            this.total = food.Price * qtyFood;
        }

    }
}
