using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Models
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2KEA18U\SQLEXPRESS;Database=EFRestaurantReservationApp;Trusted_Connection=true;TrustServerCertificate=true;");


        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Order> Orders { get; set; }






    }
}
