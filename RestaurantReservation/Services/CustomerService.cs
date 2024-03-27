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
            List<Customer> customers = context.Customers.OrderBy(x => x.Id).ToList();
            return customers;
            

        }

        public void Delete(int id)
        {
            RestaurantContext ctx = new RestaurantContext();
            Customer customer = ctx.Customers.FirstOrDefault(x => x.Id == id);
            ctx.Customers.Remove(customer);
            ctx.SaveChanges();


            
        }

        public Customer Add(string name, string surname, string phone, string email, string address)
        {
            RestaurantContext ctx = new RestaurantContext();
            Customer customer = new Customer();
            customer.Name = name;
            customer.Surname = surname;
            customer.Phone = phone;
            customer.Email = email;
            customer.Address = address;

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
