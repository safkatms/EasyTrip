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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
        private void button3_admin_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            this.Hide();
            a.Show();
        }

        private void button1_SignUp_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            this.Hide();
            p.Show();
        }

        private void button2_login_Click(object sender, EventArgs e)
        {
            if (textBox1_UserName.Text == "" || textBox2_UserPass.Text == "")
            {
                MessageBox.Show("Field are Empty");
            }
            else
            {
                string username, userpass;
                username = textBox1_UserName.Text;
                userpass = textBox2_UserPass.Text;

                try
                {



                    string query = "Select* from userInfo where Username = '" + username + "' and Password='" + userpass + "' ";



                    SqlDataAdapter cm = new SqlDataAdapter(query, con);
                    DataTable dtable = new DataTable();

                    cm.Fill(dtable);



                    if (dtable.Rows.Count > 0)
                    {
                        username = textBox1_UserName.Text;
                        userpass = textBox2_UserPass.Text;

                        DataRow dataRow = dtable.Rows[0];
                        LoggedInUserDetails.userfirstName = dataRow["FirstName"].ToString();
                        LoggedInUserDetails.userlastName = dataRow["LastName"].ToString();
                        LoggedInUserDetails.userName = dataRow["Username"].ToString();
                        LoggedInUserDetails.userEmail = dataRow["Email"].ToString();
                        LoggedInUserDetails.userPhoneNo = dataRow["PhoneNumber"].ToString();
                        LoggedInUserDetails.userDOB = dataRow["DOB"].ToString();
                        LoggedInUserDetails.userGender = dataRow["Gender"].ToString();
                        LoggedInUserDetails.userPassword = dataRow["Password"].ToString();
                        PassengerProfile pp = new PassengerProfile();
                        pp.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void button4_clear_Click(object sender, EventArgs e)
        {
            textBox1_UserName.Clear();
            textBox2_UserPass.Clear();
            textBox1_UserName.Focus();
        }

        private void adminShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (userShowPass.Checked == true)
            {
                textBox2_UserPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2_UserPass.UseSystemPasswordChar = true;
            }
        }

     

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
