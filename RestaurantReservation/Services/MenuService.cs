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

        public void Delete(int id)
        {
            Menu menu = context.Menu.Find(id);
            menu.IsDeleted = true;
            context.SaveChanges();


        }

        public List<Menu> GetAll()
        {
            List<Menu> menu = context.Menu.Where(x => x.IsDeleted == false).ToList();
            return menu;
        }

        public void Update(Menu menu)
        {
            Menu updatedMenu = context.Menu.Find(menu.Id)!;
            updatedMenu.Price = menu.Price;
            context.SaveChanges();
        }

    }
}
