using RestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantReservation.Services
{
    public class MenuService
    {
        RestaurantContext context = new RestaurantContext();
        public void Add(Menu menu)
        {

            context.Menu.Add(menu);
            context.SaveChanges();


        }

        public void Delete(Menu value)
        {
            Menu menu = context.Menu.FirstOrDefault(x=> x.Id == value.Id);
            menu.IsDeleted = true;
            context.SaveChanges();
           


        }

        public List<Menu> GetAll()
        {
            List<Menu> menu = context.Menu.Where(x=> x.IsDeleted==false).ToList();  
            return menu;
        }

        public void Update(Menu value)
        {
            var menu = context.Menu.FirstOrDefault(m => m.Id == value.Id);

            if (menu != null)
            {
                menu.Title = value.Title;
                menu.Description = value.Description;
                menu.Price = value.Price;
            }
        }

    }
}
