using System;
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
    }
}

