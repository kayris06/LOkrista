using System;
using System.Collections.Generic;
using System.Linq;

using KristaLO.Data;
using KristaLO.Models;
using KristaLO.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
            List<Meals> theMeal = context.Meal.ToList();
            return View(theMeal);
        }

        [Authorize]
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
                        Description = addMealViewModel.Description,
                        DietaryRestrictions = addMealViewModel.DietaryRestrictions
                    };

                    context.Meal.Add(newMeal);
                    context.SaveChanges();

                    return Redirect("/Meals");
                }
                return View("Add" ,addMealViewModel);
            }

        // This method will be used to create the entire dashboard 
        //public IActionResult Dashboard()
        //{
        //    List<Meals> meals = context.Meal.ToList();

        //    return View(meals);
        //}


        public IActionResult Info(int id)
        {
            {
                Meals theMeal = context.Meal.Find(id);

                return View(theMeal);
            }
            
        }
        
    }
}

