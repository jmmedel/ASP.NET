using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_002_MVC.Data.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string categoryName { get; set; }
        public string Description { get; set; }
        public List<Drink> Drinks { get; set; }

    }
}
