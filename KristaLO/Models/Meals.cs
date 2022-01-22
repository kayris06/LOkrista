﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalLiftOff.Models
{
    public class Meals
    {
        public int Id { get; set; }
     
        public int Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //public string Restrictions { get; set; }

        public Meals()
        {
         
        }

        public Meals(int price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;

        }

        
    }
}