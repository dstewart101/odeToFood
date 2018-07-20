using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    public class HomeController: Controller
    {

        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter) {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        [AllowAnonymous]
        public IActionResult Index() {
            var Model = new HomeIndexViewModel();
            Model.Restaurants = _restaurantData.GetAll();
            Model.CurrentMessage = _greeter.GetMessageOfTheDay();
            return View(Model);
        }

        [AllowAnonymous]
        public IActionResult Details(int id) {
            var model = _restaurantData.GetSingle(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model) {

            if (ModelState.IsValid) {
                var restaurant = new Restaurant
                {
                    Name = model.Name,
                    Cuisine = model.Cuisine
                };

                restaurant = _restaurantData.Add(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }
    }
}
