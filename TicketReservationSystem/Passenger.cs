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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");


        private void button1_signup_Click(object sender, EventArgs e)
        {
            if (User_firstName.Text == "" || User_lastName.Text == "" || User_userName.Text == "" || User_email.Text == "" || comboBox1_Usr_gender.Text == "" || dateTimePicker1_usrDOB.Text == "" || userPassword.Text == "")
            {
                MessageBox.Show("Field are Empty");
            }

            else
            {
                con.Open();

                string query = "select Username from userInfo where Username= '" + User_userName.Text + "'";

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
                    string query1 = "insert into userInfo values('" + User_firstName.Text + "','" + User_lastName.Text + "','" + User_userName.Text + "','" + User_email.Text + "','" + User_phn.Text + "','" + this.dateTimePicker1_usrDOB.Value.ToString("MM/dd/yyyy") + "','" + comboBox1_Usr_gender.Text + "','" + userPassword.Text + "')";

                    SqlCommand cmd = new SqlCommand(query1, con);

                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        User_firstName.Clear();
                        User_lastName.Clear();
                        User_userName.Clear();
                        User_email.Clear();
                        User_phn.Clear();
                        userPassword.Clear();

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

        private void button2_Clear_Click(object sender, EventArgs e)
        {
            User_firstName.Clear();
            User_lastName.Clear();
            User_userName.Clear();
            User_email.Clear();
            User_phn.Clear();
            userPassword.Clear();
        }

        private void button3_Back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void userShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (userShowPass.Checked == true)
            {
                userPassword.UseSystemPasswordChar = false;
            }
            else
            {
                userPassword.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
