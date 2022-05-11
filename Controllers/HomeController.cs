using LiquorStore_AspCore.Data.Interfaces;
using LiquorStore_AspCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquorStore_AspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            { 
                PreferredDrinks = _drinkRepository.IsPreferredDrink
            };
            return View(homeViewModel);
        }
    }
}
