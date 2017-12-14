using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    class FoodCtrl
    {
        List<FoodModel> listFoods;

        public List<FoodModel> ListFoods
        {
            get { return listFoods; }
            set { listFoods = value; }
        }

        public FoodCtrl()
        {
            listFoods = new List<FoodModel>();
            if (listFoods.Count == 0)
                FoodModel.ID = 0;
            else FoodModel.ID = listFoods[listFoods.Count - 1].IdFood;

            AddFood();
        }

        public void CreateFood(string name, int price, int basicPrice, string picLocal)
        {            
            FoodModel food = new FoodModel(name, price, basicPrice, picLocal);
            listFoods.Add(food);
        }

        public FoodModel FindFood(int idFood)
        {
            for (int i = 0; i < listFoods.Count; i++)
            {
                if (listFoods[i].IdFood == idFood)
                    return listFoods[i];
            }
            FoodModel output = new FoodModel();
            return output;
        }

        public void EditProductInfo(int id, string name, int price, int basicPrice, string picLocal)
        {
            int index = listFoods.IndexOf(FindFood(id));
            listFoods[index].Name = name;
            listFoods[index].Price = price;
            listFoods[index].BasicPrice = basicPrice;
            listFoods[index].PicLocal = picLocal;
        }

        private void AddFood()
        {
            FoodModel food1 = new FoodModel("Bibimbap", 45000, 30000, "..\\..\\pic\\Bibimbap.png");
            FoodModel food2 = new FoodModel("Kimchi", 15000, 10000, "..\\..\\pic\\Kimchi.png");
            FoodModel food3 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            listFoods.Add(food1);
            listFoods.Add(food2);
            listFoods.Add(food3);
            listFoods.Add(food1);
            listFoods.Add(food2);
        }
    }
}
