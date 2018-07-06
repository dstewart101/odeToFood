﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Restaurant Name")]
        [MaxLength(15, ErrorMessage = "Name is too long")]
        public String Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
