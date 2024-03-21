using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Customer:BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public int Phone { get; set; }
        public string? Address { get; set; }

    }
}
