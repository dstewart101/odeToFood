using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;
using OdeToFood.Interfaces;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class SQLRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext _context;

        public SQLRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant GetSingle(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
