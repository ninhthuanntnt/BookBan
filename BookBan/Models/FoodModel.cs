using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBan.Models
{
    [Table(Name = "TA_FOOD")]
    class FoodModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "I_ID")]
        public int Id { get; }

        [Column(Name = "T_NAME")]
        public string Name { get; set; }

        public FoodModel()
        {

        }
    }
}
