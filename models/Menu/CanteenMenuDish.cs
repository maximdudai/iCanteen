using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL_B.models.Menu
{
    public class MenuCanteenDish
    {
        [Key]
        public int Id { get; set; }
        public int MenuCanteenId { get; set; }
        public int DishId { get; set; }
    }
}
