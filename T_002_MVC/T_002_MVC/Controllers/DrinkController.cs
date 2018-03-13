using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_002_MVC.Data.Interfaces;
using T_002_MVC.Data.Model;
using Microsoft.AspNetCore.Mvc;
namespace T_002_MVC.Controllers
{
    public class DrinkController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepositorycs _drinkRepositorycs;

         public  DrinkController(ICategoryRepository categoryRepositorys, IDrinkRepositorycs drinkRepositorycss)
         {
            _categoryRepository = categoryRepositorys;
            _drinkRepositorycs = drinkRepositorycss;
         }

        public ViewResult List()
        {
            var drinks = _drinkRepositorycs.Drink;
            return View(drinks);
        }

    }

}
