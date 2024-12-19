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
    public partial class AdminUserProfile : UserControl
    {
        public AdminUserProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
        private void profileUpdate_Click(object sender, EventArgs e)
        {
            profileSave.Visible = true;
            profileUpdate.Visible = false;
            adminPassword.ReadOnly = false;
        }

        private void profileSave_Click(object sender, EventArgs e)
        {
            profileUpdate.Visible = true;
            profileSave.Visible = false;
            adminPassword.ReadOnly = true;

            string query1 = "update  adminInfo set aPassword='"+adminPassword.Text+"'";

            SqlCommand cmd = new SqlCommand(query1, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Update is Successful");
            }
            else
            {
                MessageBox.Show("Error");
            }

            con.Close();
        }

        private void adminShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (adminShowPass.Checked == true)
            {
                adminPassword.UseSystemPasswordChar = false;
            }
            else
            {
                adminPassword.UseSystemPasswordChar = true;
            }
        }

        private void AdminUserProfile_Load(object sender, EventArgs e)
        {
            User_firstName.Text = LoggedInUserDetails.userfirstName;
            User_lastName.Text = LoggedInUserDetails.userlastName;
            User_userName.Text = LoggedInUserDetails.userName;
            User_email.Text = LoggedInUserDetails.userEmail;
            User_phn.Text = LoggedInUserDetails.userPhoneNo;
            textBox2.Text = LoggedInUserDetails.userDOB;
            textBox1.Text = LoggedInUserDetails.userGender;
            adminPassword.Text = LoggedInUserDetails.userPassword;
        }
    }
}
