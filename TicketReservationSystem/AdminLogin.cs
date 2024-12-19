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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");

        private void button1_SignUp_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
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



                    string query = "Select* from adminInfo where aUsername = '" + username + "' and aPassword='" + userpass + "' ";



                    SqlDataAdapter cm = new SqlDataAdapter(query, con);
                    DataTable dtable = new DataTable();

                    cm.Fill(dtable);



                    if (dtable.Rows.Count > 0)
                    {
                        username = textBox1_UserName.Text;
                        userpass = textBox2_UserPass.Text;
                        DataRow dataRow = dtable.Rows[0];
                        LoggedInUserDetails.userfirstName = dataRow["aFirstName"].ToString();
                        LoggedInUserDetails.userlastName = dataRow["aLastName"].ToString();
                        LoggedInUserDetails.userName = dataRow["aUsername"].ToString();
                        LoggedInUserDetails.userEmail = dataRow["aEmail"].ToString();
                        LoggedInUserDetails.userPhoneNo = dataRow["aPhoneNumber"].ToString();
                        LoggedInUserDetails.userDOB = dataRow["aDOB"].ToString();
                        LoggedInUserDetails.userGender = dataRow["aGender"].ToString();
                        LoggedInUserDetails.userPassword = dataRow["aPassword"].ToString();
                        AdminProfile ap = new AdminProfile();
                        ap.Show();
                        this.Close();
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

        private void button3_User_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void adminShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(adminShowPass.Checked==true)
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
