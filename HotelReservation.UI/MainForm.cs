﻿
using HotelReservation.Entity;
using System.Drawing.Text;

namespace HotelReservation.UI
{
    public partial class MainForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        public MainForm()
        {
            InitializeComponent();
            reservations = new List<Reservation>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm();
            roomForm.Show();

        }

        private void odaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void odaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void rezervasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReservationForm addReservationForm = new AddReservationForm();
            addReservationForm.Show();
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
            LoadReservations();
        }

        private void LoadReservations() 
        {
            dgvReservations.DataSource = null;
            dgvReservations.DataSource = reservations;
        }

    }
}
