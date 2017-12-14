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
        private List<FoodModel> listFood = new List<FoodModel>();

        public List<FoodModel> ListFood
        {
            get { return listFood; }
            set { listFood = value; }
        }

        private List<FoodModel> listOrder = new List<FoodModel>();

        public OrderManagement()
        {
            AddFood();
        }

        private void AddFood()
        {
            FoodModel food1 = new FoodModel("Bibimbap", 45000, 30000, "..\\..\\pic\\Bibimbap.png");
            FoodModel food2 = new FoodModel("Kimchi", 15000, 10000, "..\\..\\pic\\Kimchi.png");
            FoodModel food3 = new FoodModel("Tteokbokki", 30000, 20000, "..\\..\\pic\\Tteokbokki.png");
            listFood.Add(food1);
            listFood.Add(food2);
            listFood.Add(food3);
            listFood.Add(food1);
            listFood.Add(food2);
        }

        public void InputOrder(FoodModel food, DataGridView dgvListOrder)
        {
            listOrder.Add(food);
            dgvListOrder.DataSource = null;
            dgvListOrder.DataSource = listOrder;
        }
    }
}
