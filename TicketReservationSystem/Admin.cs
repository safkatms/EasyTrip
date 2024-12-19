using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketReservationSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");

        private void button1_Admin_signup_Click(object sender, EventArgs e)
        {

            if (admin_firstName.Text == "" || admin_lastName.Text == "" || admin_userName.Text == "" || admin_email.Text == "" || comboBox1_admin_gender.Text == "" || dateTimePicker1_adminDOB.Text == "" || adminPassword.Text == "")
            {
                MessageBox.Show("Field are Empty");
            }
            else
            {
                con.Open();
                string query = "select aUserName from adminInfo where aUserName= '" + admin_userName.Text + "'";

                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader r = cm.ExecuteReader();

                if (r.Read())
                {
                    MessageBox.Show("Username Already Taken! ");
                    con.Close();
                }

                else
                {
                    con.Close();

                    string query1 = "insert into adminInfo values('" + admin_firstName.Text + "','" + admin_lastName.Text + "','" + admin_userName.Text + "','" + admin_email.Text + "','" + admin_phn.Text + "','" + this.dateTimePicker1_adminDOB.Value.ToString("MM/dd/yyyy") + "','" + comboBox1_admin_gender.Text + "','" + adminPassword.Text + "')";

                    SqlCommand cmd = new SqlCommand(query1, con);

                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        admin_firstName.Clear();
                        admin_lastName.Clear();
                        admin_userName.Clear();
                        admin_email.Clear();
                        admin_phn.Clear();
                        adminPassword.Clear();
                        MessageBox.Show("SignUp is Successful");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    con.Close();
                }


            }
        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }


     

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_clear_Click_1(object sender, EventArgs e)
        {
            admin_firstName.Clear();
            admin_lastName.Clear();
            admin_userName.Clear();
            admin_email.Clear();
            admin_phn.Clear();
            adminPassword.Clear();
        }

        private void button3_back_Click_1(object sender, EventArgs e)
        {
            AdminLogin l = new AdminLogin();
            l.Show();
            this.Close();
        }

        private void userShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (userShowPass.Checked == true)
            {
                adminPassword.UseSystemPasswordChar = false;
            }
            else
            {
                adminPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
