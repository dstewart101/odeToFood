using OdeToFood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Get some noms";
        }
    }
}
