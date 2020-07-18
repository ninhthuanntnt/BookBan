using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
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
        public int Id { get; set; }

        [Column(Name = "T_NAME")]
        public string Name { get; set; }

        private EntitySet<DishModel> _dishes = new EntitySet<DishModel>();

        [Association(Name = "FK__TA_DISH__I_FOOD__29572725",
            Storage = "_dishes", OtherKey = "FoodId")]
        public EntitySet<DishModel> Dishes
        {
            get
            {
                return this._dishes;
            }
            set
            {
                this._dishes.Assign(value);
            }
        }
        public FoodModel()
        {

        }
    }
}
