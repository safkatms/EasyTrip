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
    public partial class BookAir : UserControl
    {
        public BookAir()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
        private void button2_Clear_Click(object sender, EventArgs e)
        {
            comboBox_airDepart.Text = string.Empty;
            comboBox_airArrival.Text = string.Empty;

        }

        

        public void FillComboBox()
        {
            string query = "select* from airInfo";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            sda.Fill(d);

            foreach (DataRow dr in d.Rows)
            {
                comboBox_airDepart.Items.Add(dr["airDepartureLoc"].ToString());
                comboBox_airArrival.Items.Add(dr["airArrivalLoc"].ToString());
            }
        }

        private void BookAir_Load(object sender, EventArgs e)
        {
            FillComboBox();
            textBox1_airUN.Text = LoggedInUserDetails.userName;
        }


        private void button1_Search_Click(object sender, EventArgs e)
        {
            dataGridView1_availableAir.Visible = true;
            bindDataGird();
        }

        public void bindDataGird() // will show match result in data grid
        {
            string departure, arrival;

            departure = comboBox_airDepart.Text;
            arrival = comboBox_airArrival.Text;

            string query = "select* from airInfo where airDepartureLoc ='" + departure + "'and airArrivalLoc= '" + arrival + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1_availableAir.DataSource = dt;
        }

        private void dataGridView1_availableAir_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2_airId.Text = dataGridView1_availableAir.SelectedRows[0].Cells[0].Value.ToString();
            textBox3_airName.Text = dataGridView1_availableAir.SelectedRows[0].Cells[1].Value.ToString();
            textBox4_airDl.Text = dataGridView1_availableAir.SelectedRows[0].Cells[2].Value.ToString();
            textBox5_airAL.Text = dataGridView1_availableAir.SelectedRows[0].Cells[3].Value.ToString();
            textBox6_airDT.Text = dataGridView1_availableAir.SelectedRows[0].Cells[4].Value.ToString();
            textBox8_airTP.Text = dataGridView1_availableAir.SelectedRows[0].Cells[5].Value.ToString();

            panel2_TicketDetails.Visible = true;
            panel1_airSeat.Visible = true;
        }

        private void button_AirSeat(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string airid = textBox2_airId.Text;

            ////
            string query1 = "insert into airSeat values ('" + airid + "','" + b.Text + "')";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();

                b.BackColor = Color.Gray;
               
                Confirm.Enabled = true;
            }
            con.Close();
            ////

            ////
            string query2 = "select AirSeatNo from airSeat where AirId='" + airid + "'";

            SqlCommand cm = new SqlCommand(query2, con);

            con.Open();
            SqlDataReader rd;

            rd = cm.ExecuteReader();

            while (rd.Read())
            {
                textBox7_airSN.Text = rd.GetValue(0).ToString();
            }
            con.Close();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2_airId.Clear();
            textBox3_airName.Clear();
            textBox4_airDl.Clear();
            textBox5_airAL.Clear();
            textBox6_airDT.Clear();
            textBox7_airSN.Clear();
            textBox8_airTP.Clear();
            panel1_airSeat.Visible= false;
            panel2_TicketDetails.Visible = false;
        }

        private void textBox7_airSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string airSeatNo = textBox7_airSN.Text;
            con.Open();
            string query = "select airSeatNo from airTicketInfo where airSeatNo= '" + airSeatNo + "'";

            SqlCommand cm1 = new SqlCommand(query, con);

            SqlDataReader mrd = cm1.ExecuteReader();
            if (mrd.Read())
            {
                MessageBox.Show("Already Booked");
                con.Close();
            }
            else
            {
                con.Close();
                string query1 = "insert into airTicketInfo values('" + textBox1_airUN.Text + "','" + textBox2_airId.Text + "','" + textBox3_airName.Text + "','" + textBox4_airDl.Text + "','" + textBox5_airAL.Text + "','" + textBox6_airDT.Text + "','" + textBox7_airSN.Text + "','" + textBox8_airTP.Text + "')";

                SqlCommand cmd = new SqlCommand(query1, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("confirm ");
                }
                else
                {
                    MessageBox.Show("Error");
                }

                con.Close();
            }
        }

       
    }
}
