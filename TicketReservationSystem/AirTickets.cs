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
    public partial class AirTickets : UserControl
    {
        public AirTickets()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirTickets_Load(object sender, EventArgs e)
        {
            bindDataGird();
        }

        public void bindDataGird() // will show match result in data grid
        {
            string userName = LoggedInUserDetails.userName;

            string query = "select* from airTicketInfo where Username ='" + userName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);



            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Cancel")
            {
                string seatId;
                seatId = dataGridView1.Rows[e.RowIndex].Cells["AirSeatNo"].Value.ToString();
                string query = "delete from airTicketInfo where AirSeatNo=@id ";



                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.Parameters.AddWithValue("@id", seatId);


                con.Open();



                if (con.State == ConnectionState.Open)
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Cancel Successful");
                    bindDataGird();
                }
                else
                {
                    MessageBox.Show("Failed ");
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindDataGird();
        }
    }
}
