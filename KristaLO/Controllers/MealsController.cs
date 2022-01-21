﻿using System;
using FinalLiftOff.Models;
using KristaLO.Data;
using KristaLO.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KristaLO.Controllers
{
    public class MealsController : Controller
    {
        private NourishDbContext context;
       
        public MealsController(NourishDbContext dbContext)
        {
            context = dbContext;
        }
        //Get: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Add()
        {
            AddMealViewModel addMealViewModel = new AddMealViewModel();
            return View(addMealViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddMealViewModel addMealViewModel)
        {
            if (ModelState.IsValid)
            {
             
                Meals newMeal = new Meals
                {
                    Price = addMealViewModel.Price,
                    Name = addMealViewModel.Name,
                    Description = addMealViewModel.Description
           
                };

                return Redirect("/Meals");
            }
            return View(addMealViewModel);
        }
       
        public IActionResult Info()
        {
            return View();
        }
        
    }
}

