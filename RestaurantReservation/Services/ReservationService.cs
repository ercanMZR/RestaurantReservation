using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Services
{

    public class ReservationService
    {
        RestaurantContext context = new RestaurantContext();

        public void Add(Reservation value)
        {
            context.Reservations.Add(value);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id == id);
            reservation.IsDeleted = true;
            context.SaveChanges();

        }

        public List<Reservation> GetAll()
        {
          List<Reservation>reservations= context.Reservations.Where(x => x.IsDeleted == false).ToList();
            return reservations;
        }

        public void Update(Reservation value)
        {
            Reservation reservation = context.Reservations.Find(value.Id);

        }
    }
}


    

