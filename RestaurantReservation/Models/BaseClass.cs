﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public  class BaseClass
    {
        [Key]
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }

    }
}
