using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    public class Food
    {
        private static int iD = 0;
        private int idFood;
        private string name;
        private int price;
        private int basicPrice;
        private string picLocal;

        public static int ID { get => iD; set => iD = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int BasicPrice { get => basicPrice; set => basicPrice = value; }
        public string PicLocal { get => picLocal; set => picLocal = value; }

        public Food()
        {
            this.idFood = iD++;
        }

        public Food(string name, int price, int basicPrice, string picLocal)
        {
            this.idFood = iD++;
            this.Name = name;
            this.Price = price;
            this.BasicPrice = basicPrice;
            this.PicLocal = picLocal;
        }

        public Food(Food Food)
        {
            this.Name = Food.Name;
            this.Price = Food.Price;
            this.BasicPrice = Food.BasicPrice;
            this.PicLocal = Food.PicLocal;
        }
    }
}
