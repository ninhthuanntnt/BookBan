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

        private SqlServerDatabase db;


        public FoodDAO()
        {
            db = new SqlServerDatabase();
        }

        public FoodModel getById(int id)
        {
            FoodModel food = null;

            IEnumerable<FoodModel> foodTemp = from f in db.foods
                                              join d in db.dishes on f.Id equals d.FoodId
                                              where f.Id == id
                                              select f;

            IEnumerable<DishModel> dishTemp = from d in db.dishes
                                              join f in db.foods on d.FoodId equals f.Id
                                              where d.Id == id
                                              select d;

            foreach (DishModel f in dishTemp)
            {
                var dish = f;
                Console.WriteLine(f);
            }

            return food;
        }
    }
}
