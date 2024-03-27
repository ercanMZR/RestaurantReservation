using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RestaurantReservation.Services
{
    public class CustomerService
    {
        public List<Customer> GetAll()
        {
            RestaurantContext context = new RestaurantContext();
            List<Customer> customers = context.Customers.Where(x=>x.IsDeleted==false).ToList();
            return customers;
            

        }

        public void Delete(Customer value)
        {
            RestaurantContext ctx = new RestaurantContext();
            Customer customer = ctx.Customers.FirstOrDefault(x => x.Id == value.Id);

            customer.IsDeleted=true;
            ctx.SaveChanges();


            
        }

        public Customer Add(Customer customer)
        {
            RestaurantContext context = new RestaurantContext();
            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }
        public void Update(Customer value)
        {
            RestaurantContext context =new RestaurantContext();

            var foundCustomer = context.Customers.FirstOrDefault(c => c.Id == value.Id);

            if (foundCustomer != null)
            {
                foundCustomer.Name = value.Name;
                foundCustomer.Surname = value.Surname;
                foundCustomer.Address = value.Address;
                foundCustomer.Email = value.Email;
                foundCustomer.Phone = value.Phone;
            }


        }
    }
}
