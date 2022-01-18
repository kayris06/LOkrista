using System;
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

        [HttpPost]
        [Route("/Meals")]
        public IActionResult Add()
        {
            return View("/Add");
        }
    }
}

