using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_002_MVC.Data.Interfaces;
using T_002_MVC.Data.Model;

namespace T_002_MVC.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { categoryName = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { categoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }
}
