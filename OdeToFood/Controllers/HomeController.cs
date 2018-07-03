using Microsoft.AspNetCore.Mvc;
using OdeToFood.Interfaces;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController: Controller
    {

        public IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData) {
            _restaurantData = restaurantData;
        }

        public IActionResult Index() {
            var Model = _restaurantData.GetAll();
            return View(Model);
        }
    }
}
