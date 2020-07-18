using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBan.Models
{
    [Table(Name = "TA_DISH")]
    class DishModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "I_ID")]
        public int Id { get; set; }
        
        [Column(Name = "T_NAME")]
        public string Name { get; set; }

        [Column(Name = "I_PRICE")]
        public int Price { get; set; }

        [Column(Name = "I_FOOD")]
        public int? FoodId { get; set; }

        private EntityRef<FoodModel> _food = new EntityRef<FoodModel>();

        [Association(Name = "FK__TA_DISH__I_FOOD__29572725", Storage = "_food", ThisKey = "FoodId", IsForeignKey = true)]
        public FoodModel Food
        {
            get
            {
                return this._food.Entity;
            }
            set
            {
                this._food.Entity = value;
            }
        }
    }
}
