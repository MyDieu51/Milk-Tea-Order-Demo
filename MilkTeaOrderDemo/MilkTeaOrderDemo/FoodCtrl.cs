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

        public FoodCtrl()
        {

        }

        public void CreateMenu(string name, int price, int basicPrice, string picLocal)
        {
            if (listFoods.Count == 0)
                FoodModel.ID = 0;
            else FoodModel.ID = listFoods[listFoods.Count - 1].IdFood;
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
    }
}
