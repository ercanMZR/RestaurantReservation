﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class Menu:BaseClass
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

    }
}
