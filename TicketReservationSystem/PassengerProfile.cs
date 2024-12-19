using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
    public partial class PassengerProfile : Form
    {
        public PassengerProfile()
        {
            InitializeComponent();
        }

        

        private void button1_book_Click(object sender, EventArgs e)
        {
            label1_Home.Visible = false;
            Air.Visible = false;
            Bus.Visible = false;
            busTicketd.Visible = false;
            airTicketd.Visible = false;
            button1_bus.Visible = true;
            button2_air.Visible = true;
            airTickets.Visible = false;
            busTickets.Visible = false;
            passengerUserProfile1.Visible = false;
            airTickets1.Visible = false;
            busTickets1.Visible = false;
            bookAir1.Visible = false;
            bookBus1.Visible = false;
            panel3.Visible = true;
        }

        private void button5_ticketDetails_Click(object sender, EventArgs e)
        {
            label1_Home.Visible = false;
            Air.Visible = false;
            Bus.Visible = false;
            busTicketd.Visible = false;
            airTicketd.Visible = false;
            busTickets.Visible = true;
            airTickets.Visible = true;
            button1_bus.Visible = false;
            button2_air.Visible = false;
            passengerUserProfile1.Visible = false;
            airTickets1.Visible = false;
            busTickets1.Visible = false;
            bookAir1.Visible = false;
            bookBus1.Visible = false;
            panel3.Visible = true;
        }

        

        private void label1air_Profile_Click(object sender, EventArgs e)
        {

        }

        private void button1_bus_Click(object sender, EventArgs e)
        {
            label1_Home.Visible = false;
            Air.Visible = false;
            Bus.Visible = true;
            busTicketd.Visible = false;
            airTicketd.Visible = false;
            bookBus1.Visible = true;
            bookAir1.Visible = false;
            passengerUserProfile1.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_air_Click(object sender, EventArgs e)
        {
            label1_Home.Visible = false;
            Air.Visible = true;
            Bus.Visible = false;
            busTicketd.Visible = false;
            airTicketd.Visible = false;
            bookAir1.Visible = true;
            bookBus1.Visible = false;
            passengerUserProfile1.Visible = false;
            panel3.Visible = false;
            
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            label1_Home.Visible = true;
            Air.Visible = false;
            Bus.Visible = false;
            busTicketd.Visible = false;
            airTicketd.Visible = false;
            bookAir1.Visible = false;
            bookBus1.Visible = false;
            passengerUserProfile1.Visible = true;
            button1_bus.Visible = false;
            button2_air.Visible = false;
            airTickets.Visible = false;
            busTickets.Visible = false;
            airTickets1.Visible = false;
            busTickets1.Visible = false;
            panel3.Visible = false;
        }

        private void user_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }

        private void busTickets_Click(object sender, EventArgs e)
        {
            busTicketd.Visible = true;
            airTicketd.Visible = false;
            label1_Home.Visible = false;
            Air.Visible = false;
            Bus.Visible = false;
            passengerUserProfile1.Visible = false;
            bookAir1.Visible = false;
            bookBus1.Visible = false;
            busTickets1.Visible = true;
            airTickets1.Visible = false;
            panel3.Visible = false;
        }

        private void airTickets_Click(object sender, EventArgs e)
        {
            busTicketd.Visible = false;
            airTicketd.Visible = true;
            label1_Home.Visible = false;
            Air.Visible = false;
            Bus.Visible = false;
            passengerUserProfile1.Visible = false;
            bookAir1.Visible = false;
            bookBus1.Visible = false;
            busTickets1.Visible = false;
            airTickets1.Visible = true;
            panel3.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassengerProfile_Activated(object sender, EventArgs e)
        {
         
        }
    }
}
