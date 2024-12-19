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
    public partial class PassengerUserProfile : UserControl
    {
        public PassengerUserProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");

        private void profileUpdate_Click(object sender, EventArgs e)
        {
            profileSave.Visible = true;
            profileUpdate.Visible = false;
            userPassword.ReadOnly = false;
        }

        private void profileSave_Click(object sender, EventArgs e)
        {
            profileUpdate.Visible = true;
            profileSave.Visible = false;
            userPassword.ReadOnly = true;

            string query1 = "update  userInfo set Password='" + userPassword.Text + "'";

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

        private void PassengerUserProfile_Load(object sender, EventArgs e)
        {
            User_firstName.Text = LoggedInUserDetails.userfirstName;
            User_lastName.Text = LoggedInUserDetails.userlastName;
            User_userName.Text = LoggedInUserDetails.userName;
            User_email.Text = LoggedInUserDetails.userEmail;
            User_phn.Text = LoggedInUserDetails.userPhoneNo;
            user_dob.Text = LoggedInUserDetails.userDOB;
            user_gender.Text = LoggedInUserDetails.userGender;
            userPassword.Text = LoggedInUserDetails.userPassword;
        }

      
    }
}
