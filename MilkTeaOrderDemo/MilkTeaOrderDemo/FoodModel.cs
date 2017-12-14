using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    public class FoodModel
    {
        private static int iD;
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

        public FoodModel()
        {

        }

        public FoodModel(string name, int price, int basicPrice, string picLocal)
        {
            this.Name = name;
            this.Price = price;
            this.BasicPrice = basicPrice;
            this.PicLocal = picLocal;
        }

        public FoodModel(FoodModel Food)
        {
            this.Name = Food.Name;
            this.Price = Food.Price;
            this.BasicPrice = Food.BasicPrice;
            this.PicLocal = Food.PicLocal;
        }
    }
}
