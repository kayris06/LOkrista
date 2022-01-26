using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KristaLO.Models
{
    public class Meals
    {
        public int Id { get; set; }
     
        public int Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DietaryRestrictions { get; set; }

        //public string Restrictions { get; set; }

        public Meals(int price, string name, string description, string dietaryRestrictions)
        {
            Price = price;
            Name = name;
            Description = description;
            DietaryRestrictions = dietaryRestrictions;

        }
        public Meals()
        {
         
        }

        

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Meals @meals &&
                   Id == @meals.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}