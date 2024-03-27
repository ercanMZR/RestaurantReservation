using Microsoft.EntityFrameworkCore.Diagnostics;
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
using System.Xml.Linq;

namespace RestaurantReservation.Forms
{
    public partial class AddCustomer : Form
    {

        int selectedCustomerId;
        public AddCustomer()
        {
            InitializeComponent();
        }

        CustomerService customerService = new CustomerService();
        RestaurantContext restaurantContext = new RestaurantContext();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RestaurantContext context = new RestaurantContext();
            try
            {
                selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                var customer = context.Customers.FirstOrDefault(c => c.Id == selectedCustomerId);

                customer.Name = txtName.Text.Trim();
                customer.Surname = txtSurname.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAdress.Text.Trim();

                customerService.Update(customer);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = txtName.Text.Trim();
                customer.Surname = txtSurname.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAdress.Text.Trim();

                customerService.Add(customer);
                LoadData();
                MessageBox.Show("Customer added succesfully.");



            }
            catch (Exception)
            {

                MessageBox.Show("An error occured");
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = customerService.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RestaurantContext context = new RestaurantContext();



            selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var customer = context.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);

            if (customer != null)
            {
                customerService.Delete(customer);
            }

            LoadData();



        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestaurantContext ctx = new RestaurantContext();
            selectedCustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            Customer customer = ctx.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);

            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtAdress.Text = customer.Address;
        }
    }
}
