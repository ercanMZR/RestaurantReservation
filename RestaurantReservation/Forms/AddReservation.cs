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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }
        ReservationService reservationService;
        CustomerService customerService = new CustomerService();
        Reservation reservation = new Reservation();
        RestaurantContext context;
        private void AddReservation_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbCustomers.DataSource = customerService.GetAll();
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.ValueMember = "Value";




        }

        public void LoadData()          
        {
            
            List<Reservation>reservations= reservationService.GetAll();
            dataGridView1.DataSource= reservations;
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var reservation=context.Reservations.FirstOrDefault(x => x.Id == id);

            if (reservation != null)
            {
                reservationService.Delete(id);
            }

            LoadData();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            reservation = context.Reservations.FirstOrDefault(x => x.Id == id)!;
            txtNotes.Text = reservation.Notes;
            dateTimeReservation.Value = Convert.ToDateTime(reservation.ReservationDate);
            Customer customer = (Customer)cmbCustomers.SelectedItem;
            cmbCustomers.SelectedItem = Convert.ToInt32(reservation.Id);
            

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reservation.CustomersId = (int)cmbCustomers.SelectedValue;
            reservation.ReservationDate = dateTimeReservation.Value;
            reservation.Notes=txtNotes.Text;

            reservationService.Add(reservation);
            LoadData() ;

           
                

        }
    }
}
