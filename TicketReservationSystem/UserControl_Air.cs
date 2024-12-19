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
    public partial class UserControl_Air : UserControl
    {
        public UserControl_Air()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
      

        private void add_air_Click(object sender, EventArgs e)
        {

            con.Open();

            string query = "select airID from airInfo where airID = '" + textBox1_airId.Text + "'";

            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader r = cm.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("AIR ID aleady taken ! ");
                con.Close();
            }

            else
            {
                con.Close();
                string query1 = "insert into airInfo values('" + textBox1_airId.Text + "','" + textBox2_airName.Text + "','" + textBox3_airDepartLoc.Text + "','" + textBox4_airArrivalLoc.Text + "','" + this.dateTimePicker1_airDepartTime.Value.ToString("MM/dd/yyyy") + "','" + textBox5_airTicketPrice.Text + "','" + textBox6_airAvailableSeat.Text + "')";

                SqlCommand cmd = new SqlCommand(query1, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    textBox1_airId.Clear();
                    textBox2_airName.Clear();
                    textBox3_airDepartLoc.Clear();
                    textBox4_airArrivalLoc.Clear();
                    textBox5_airTicketPrice.Clear();
                    textBox6_airAvailableSeat.Clear();
                    MessageBox.Show("Add Successful");
                    bindDataGird();
                    add_air.Focus();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();
            }
        }
        public void bindDataGird()
        {
            string query = "select* from airInfo";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1_air.DataSource = dt;
        }

        private void air_delete_Click(object sender, EventArgs e)
        {
            string query = "delete from airInfo where airId='" + textBox1_airId.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd1.ExecuteNonQuery();
                textBox1_airId.Clear();
                textBox2_airName.Clear();
                textBox3_airDepartLoc.Clear();
                textBox4_airArrivalLoc.Clear();
                textBox5_airTicketPrice.Clear();
                textBox6_airAvailableSeat.Clear();
                MessageBox.Show("Delete Successful");
                bindDataGird();
            }
            else
            {
                MessageBox.Show("Failed ");
            }
            con.Close();
        }

        private void button5_Details_Click(object sender, EventArgs e)
        {
            dataGridView1_air.Visible = true;
            bindDataGird();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string query = "update airInfo set airId='" + textBox1_airId.Text + "' ,airName='" + textBox2_airName.Text + "',airDepartureLoc='" + textBox3_airDepartLoc.Text + "',airArrivalLoc='" + textBox4_airArrivalLoc.Text + "',airDepartureTime='" + this.dateTimePicker1_airDepartTime.Value.ToString("MM/dd/yyyy") + "',airTicketPrice='" + textBox5_airTicketPrice.Text + "',airAvailableSeat='" + textBox6_airAvailableSeat.Text + "'where airId='" + textBox1_airId.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd1.ExecuteNonQuery();
                textBox1_airId.Clear();
                textBox2_airName.Clear();
                textBox3_airDepartLoc.Clear();
                textBox4_airArrivalLoc.Clear();
                textBox5_airTicketPrice.Clear();
                textBox6_airAvailableSeat.Clear();
                MessageBox.Show("update Successful");
                bindDataGird();
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void dataGridView1_air_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
            textBox1_airId.Text = dataGridView1_air.SelectedRows[0].Cells[0].Value.ToString();
            textBox2_airName.Text = dataGridView1_air.SelectedRows[0].Cells[1].Value.ToString();
            textBox3_airDepartLoc.Text = dataGridView1_air.SelectedRows[0].Cells[2].Value.ToString();
            textBox4_airArrivalLoc.Text = dataGridView1_air.SelectedRows[0].Cells[3].Value.ToString();
            textBox5_airTicketPrice.Text = dataGridView1_air.SelectedRows[0].Cells[5].Value.ToString();
            textBox6_airAvailableSeat.Text = dataGridView1_air.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
