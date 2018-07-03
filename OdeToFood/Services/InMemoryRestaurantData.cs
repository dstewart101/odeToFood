using OdeToFood.Interfaces;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> _restaurants;

        public InMemoryRestaurantData() {
            _restaurants = new List<Restaurant> {
                new Restaurant { Id = 1, Name = "Marko's"},
                new Restaurant { Id = 2, Name = "Lucky Golden Palace"},
                new Restaurant { Id = 3, Name = "Swathi's Palace"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }



    }
}
