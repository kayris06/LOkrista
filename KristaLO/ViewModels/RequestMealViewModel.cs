using System;
using System.Collections.Generic;
using FinalLiftOff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KristaLO.ViewModels
{
    public class RequestMealViewModel
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public int Portion { get; set; }

        public string Meal { get; set; }

        public List<SelectListItem> DietaryR { get; set; }

        public string NameCustomer { get; set; }

        public string NameCook { get; set; }

        public List<Payment> Paymenttype { get; set; }

        public bool AvailableNow { get; set; }

        public bool PreOrder { get; set; }

        public RequestMealViewModel()
        {
        }
    }
}
