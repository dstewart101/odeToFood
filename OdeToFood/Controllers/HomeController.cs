using Microsoft.AspNetCore.Mvc;
using OdeToFood.Interfaces;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController: Controller
    {

        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter) {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index() {
            var Model = new HomeIndexViewModel();
            Model.Restaurants = _restaurantData.GetAll();
            Model.CurrentMessage = _greeter.GetMessageOfTheDay();
            return View(Model);
        }

        public IActionResult Details(int id) {
            var model = _restaurantData.GetSingle(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
