using System;
using FinalLiftOff.Models;
using KristaLO.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KristaLO.Controllers
{
    public class MealsController : Controller
    {
        public MealsController()
        {
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

                return Redirect("/Meals/Info");
            }
            return View(addMealViewModel);
        }
    }
}

