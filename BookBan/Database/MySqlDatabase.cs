using BookBan.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookBan.Database
{
    [Database(Name = "BookBan")]
    class MySqlDatabase : DataContext
    {
        public Table<FoodModel> foods;
        private const string connString = "Data Source=dv.wygo.club; Initial Catalog=BookBan; User Id=web101010; Password=web101010;";
        public MySqlDatabase() : base(connString) { }
    }
}
