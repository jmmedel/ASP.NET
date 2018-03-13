using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_002_MVC.Data.Model
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal price { get; set; }
        public string  ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public string IspreferredDrink { get; set; }
        public bool isPreferedDrink { get; set; }
        public int Instock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
