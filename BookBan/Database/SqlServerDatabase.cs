using BookBan.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBan.Database
{
    [Database]
    class SqlServerDatabase : DataContext
    {
        public Table<FoodModel> foods;
        public Table<DishModel> dishes;
        private const string connString = "Server=localhost\\SQLEXPRESS;Database=BookBan;Trusted_Connection=True;";
        public SqlServerDatabase() : base(connString) { }
    }
}
