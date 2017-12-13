using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    public class FoodModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int basicPrice;

        public int BasicPrice
        {
            get { return basicPrice; }
            set { basicPrice = value; }            
        }

        private string picLocal;

        public string PicLocal
        {
            get { return picLocal; }
            set { picLocal = value; }
        }

        public FoodModel()
        {

        }

        public FoodModel(string name, int price, int basicPrice, string picLocal)
        {
            this.name = name;
            this.price = price;
            this.basicPrice = basicPrice;
            this.picLocal = picLocal;
        }
    }
}
