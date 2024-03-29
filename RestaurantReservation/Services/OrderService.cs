using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Services
{
    public class OrderService
    {
        RestaurantContext context = new RestaurantContext();

        public void Add (Order value)
        {
            context.Orders.Add(value);
            context.SaveChanges();


        }

        public void Delete(int  id)
        {
            Order order = context.Orders.FirstOrDefault(o => o.Id == id);
            order.IsDeleted = true;
            context.SaveChanges();

        }
        public List<Order> GetAll()
        {
            return context.Orders.Where(o=> o.IsDeleted==false).ToList();

        }

        public void Update(Order value)
        {

        }
    }
}
