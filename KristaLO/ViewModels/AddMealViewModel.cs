using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KristaLO.ViewModels
{
    public class AddMealViewModel
    {
        public List<SelectListItem> Restrictions { get; set; }
        public AddMealViewModel()
        {
        }
    }
}
