﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KristaLO.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KristaLO.ViewModels
{
    public class AddMealViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Meal name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public string DietaryRestrictions { get; set; }

        //public List<Restrictions> Restrictions { get; set; }


        public AddMealViewModel()
        {

        }
    }
}
