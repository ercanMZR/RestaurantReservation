using RestaurantReservation.Models;
using RestaurantReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservation.Forms
{
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }
        RestaurantContext context = new RestaurantContext();
        MenuService MenuService = new MenuService();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Menu menu = new Menu();
                menu.Title = txtTitle.Text;
                menu.Description = txtDescription.Text;
                menu.Price = Convert.ToDecimal(txtPrice.Text);

                MenuService.Add(menu);

                MessageBox.Show("Menu added succesfully.");


            }
            catch (Exception)
            {

                MessageBox.Show("An error occured");
            }

        }

        private void AddMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvMenus.DataSource = MenuService.GetAll();


        }

        int selectedMenuId;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMenuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["Id"].Value);
                var menu = context.Menu.FirstOrDefault(m => m.Id == selectedMenuId);

                menu.Title = txtTitle.Text.Trim();
                menu.Description = txtDescription.Text.Trim();
                menu.Price = Convert.ToDecimal(txtPrice.Text);

                MenuService.Update(menu);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedMenuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["Id"].Value);
            var menu = context.Menu.FirstOrDefault(x => x.Id == selectedMenuId);
            if (menu != null)
            {
                MenuService.Delete(menu);
            }
            LoadData();
        }
    }
}

