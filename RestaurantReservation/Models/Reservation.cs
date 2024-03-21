using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Reservation:BaseClass
    {
        public int CustomersId { get; set; }
        [ForeignKey("CustomersId")]
        public Customer Customers { get; set; }
        public DateTime ReservationDate { get; set; }

    }
}
