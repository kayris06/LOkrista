using System;
namespace KristaLO.Models
{
    public class Request
    {
        public int Price { get; set; }

        public int Portion { get; set; }

        public string Meal { get; set; }

        public List<Restrictions> DietaryR { get; set; }

        public string NameCustomer { get; set; }

        public string NameCook { get; set; }

        public List<Payment> Paymenttype { get; set; }

        public bool AvailableNow { get; set; }

        public bool PreOrder { get; set; }

        public Request()
        {
        }
    }
}
