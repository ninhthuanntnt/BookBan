using BookBan.Database;
using BookBan.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan.DAO
{
    class FoodDAO
    {
        private const string TABLE_FOOD = "TA_FOOD";
        private const string COL_NAME = "T_NAME";
        private const string COL_ID = "I_ID";

        private MySqlDatabase db;


        public FoodDAO()
        {
            db = new MySqlDatabase();
        }

        public FoodModel getById(int id)
        {
            FoodModel food = null;

            IEnumerable<FoodModel> foodTemp = from f in db.foods
                                              where f.Id == id
                                              select f;

            foreach (FoodModel f in foodTemp)
            {
                food = f;
            }

            return food;
        }
    }
}
