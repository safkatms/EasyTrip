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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        

        private void button1_air_Click(object sender, EventArgs e)
        {
            label1_Profile.Visible = false;
            label1_air.Visible = true;
            label1_bus.Visible = false;
            userControl_Air1.Visible = true;
            adminUserProfile1.Visible = false;
            userControl_Bus1.Visible = false;
            panel3.Visible = false;
            
        }

        private void button1_bus_Click(object sender, EventArgs e)
        {
            label1_Profile.Visible = false;
            label1_air.Visible = false;
            label1_bus.Visible = true;
            userControl_Bus1.Visible = true;
            adminUserProfile1.Visible = false;
            userControl_Air1.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Home_Click(object sender, EventArgs e)
        {
            label1_Profile.Visible = true;
            label1_air.Visible = false;
            label1_bus.Visible = false;
            userControl_Air1.Visible = false;
            userControl_Bus1.Visible = false;
            adminUserProfile1.Visible = true;
            panel3.Visible = false;
        }


        private void user_logout_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            this.Close();
            al.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
