using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalLiftOff.Models
{
    public class Meals
    {
        public int MealID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SelectListItem> Restrictions { get; set; }

        public Meals()
        {
        }
        public Meals(string name, string description, List<Restrictions> dietaryRestrictions)
    }
}