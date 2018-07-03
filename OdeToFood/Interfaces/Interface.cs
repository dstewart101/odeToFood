﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Interfaces
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}