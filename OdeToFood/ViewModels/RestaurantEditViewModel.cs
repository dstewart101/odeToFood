using OdeToFood.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required]
        [Display(Name = "Restaurant Name: ")]
        [MaxLength(15, ErrorMessage = "Name is too long")]
        public String Name { get; set; }
        [Display(Name = "Type of Cuisine: ")]
        public CuisineType Cuisine { get; set; }
    }
}
