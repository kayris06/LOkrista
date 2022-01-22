using System;
using KristaLO.Models;

namespace KristaLO.ViewModels
{
    public class MealInfoViewModel
    {
        public int MealId { get; set; }

        public int Price { get; set; }

        public string MealName { get; set; }

        public string Description { get; set; }

        public MealInfoViewModel(Meals theMeal)

        {
            MealId = theMeal.Id;
            Price = theMeal.Price;
            MealName = theMeal.Name;
            Description = theMeal.Description;


        }
    }
}

