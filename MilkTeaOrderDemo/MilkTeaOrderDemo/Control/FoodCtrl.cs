using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public class FoodCtrl
    {
        private static string path = "..\\..\\data\\FoodData.txt";
        BindingList<Food> listFoods;

        public BindingList<Food> ListFoods
        {
            get { return listFoods; }
            set { listFoods = value; }
        }

        public FoodCtrl()
        {
            listFoods = new BindingList<Food>();
            IOMethods.Instance.ReadData<Food>(path, ref listFoods);
            if (listFoods.Count != 0)
                Food.ID = listFoods[listFoods.Count - 1].IdFood + 1;       
        }

        public void CreateFood(string name, int price, int basicPrice, string picLocal, DataGridView dgvMenu)
        {
            Food food = new Food(name, price, basicPrice, picLocal);
            listFoods.Add(food);
            IOMethods.Instance.WriteNewData<Food>(path, food);
            dgvMenu.DataSource = listFoods;
        }

        public void LoadFoodInfo(int index, TextBox txtID, TextBox txtName, TextBox txtPrice, TextBox txtBasicPrice, PictureBox picBox)
        {
            txtID.Text = listFoods[index].IdFood.ToString();
            txtName.Text = listFoods[index].Name;
            txtPrice.Text = listFoods[index].Price.ToString();
            txtBasicPrice.Text = listFoods[index].BasicPrice.ToString();
            picBox.ImageLocation = listFoods[index].PicLocal;
        }

        public void EditFoodInfo(int id, string name, int price, int basicPrice, string picLocal, DataGridView dgvMenu)
        {
            int index = FindFood(id);
            listFoods[index].Name = name;
            listFoods[index].Price = price;
            listFoods[index].BasicPrice = basicPrice;
            listFoods[index].PicLocal = picLocal;
            IOMethods.Instance.EditData<Food>(path, listFoods);
            dgvMenu.DataSource = listFoods;
        }

        public void DeleteFoodInfo(int id, DataGridView dgvMenu)
        {
            int index = FindFood(id); ;
            File.Delete(listFoods[index].PicLocal);
            listFoods.RemoveAt(index);
            if (listFoods.Count != 0)
                Food.ID = listFoods[listFoods.Count - 1].IdFood + 1;
            else Food.ID = 0;
            IOMethods.Instance.EditData<Food>(path, listFoods);
            dgvMenu.DataSource = listFoods;
        }

        private int FindFood(int id)
        {
            int index = -1;
            for (int i = 0; i < listFoods.Count; i++)
            {
                if (listFoods[i].IdFood == id)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
