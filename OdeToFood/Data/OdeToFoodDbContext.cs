using Microsoft.EntityFrameworkCore;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {

        public OdeToFoodDbContext(DbContextOptions options) :base(otions)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
