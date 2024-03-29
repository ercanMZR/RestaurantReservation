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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        RestaurantContext db = new RestaurantContext();
        OrderService orderService = new OrderService();


        private void AddOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = orderService.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.MenuId = (int)cmbMenus.SelectedValue;
            order.ReservationId = (int)
                cmbReservCustomer.SelectedValue!;
            order.OrderDate = dtmOrderDate.Value;
            order.Quantity = Convert.ToInt32(txtQuantity.Text);

            orderService.Add(order);
            LoadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            orderService.Delete(id);
            LoadData() ;

        }
    }
}
