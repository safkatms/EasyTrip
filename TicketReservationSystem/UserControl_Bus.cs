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
    public partial class UserControl_Bus : UserControl
    {
        public UserControl_Bus()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");

        private void add_Bus_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "select busID from busInfo where busID = '" + textBox1_busId.Text + "'";

            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader r = cm.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Bus Id Already Taken! ");
                con.Close();
            }

            else
            {
                con.Close();

                string query1 = "insert into busInfo values('" + textBox1_busId.Text + "','" + textBox2_busName.Text + "','" + textBox3_busDepartureLoc.Text + "','" + textBox4_busArrivalLoc.Text + "','" + this.dateTimePicker1_busDepartTime.Value.ToString("MM/dd/yyyy") + "','" + textBox5_busTicketPrice.Text + "','" + textBox6_busAvailableSeat.Text + "')";

                SqlCommand cmd = new SqlCommand(query1, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    textBox1_busId.Clear();
                    textBox2_busName.Clear();
                    textBox3_busDepartureLoc.Clear();
                    textBox4_busArrivalLoc.Clear();
                    textBox5_busTicketPrice.Clear();
                    textBox6_busAvailableSeat.Clear();
                    MessageBox.Show("Add Successful");
                    bindDataGird();
                    add_Bus.Focus();
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
            string query = "select* from busInfo";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1_bus.DataSource = dt;
        }

        private void button5_showallDetails_Click(object sender, EventArgs e)
        {
            dataGridView1_bus.Visible = true;
            bindDataGird();
        }

        

        private void dataGridView1_bus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1_busId.Text = dataGridView1_bus.SelectedRows[0].Cells[0].Value.ToString();
            textBox2_busName.Text = dataGridView1_bus.SelectedRows[0].Cells[1].Value.ToString();
            textBox3_busDepartureLoc.Text = dataGridView1_bus.SelectedRows[0].Cells[2].Value.ToString();
            textBox4_busArrivalLoc.Text = dataGridView1_bus.SelectedRows[0].Cells[3].Value.ToString();
            textBox5_busTicketPrice.Text = dataGridView1_bus.SelectedRows[0].Cells[5].Value.ToString();
            textBox6_busAvailableSeat.Text = dataGridView1_bus.SelectedRows[0].Cells[6].Value.ToString();
        }

       

        private void busUpdate_Click(object sender, EventArgs e)
        {
            string query = "update busInfo set busId='" + textBox1_busId.Text + "' ,busName='" + textBox2_busName.Text + "',busDepartureLoc='" + textBox3_busDepartureLoc.Text + "',busArrivalLoc='" + textBox4_busArrivalLoc.Text + "',busDepartureTime='" + this.dateTimePicker1_busDepartTime.Value.ToString("MM/dd/yyyy")+ "',busTicketPrice='" + textBox5_busTicketPrice.Text + "',busAvailableSeat='" + textBox6_busAvailableSeat.Text + "'where busId='" + textBox1_busId.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);

            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd1.ExecuteNonQuery();
                textBox1_busId.Clear();
                textBox2_busName.Clear();
                textBox3_busDepartureLoc.Clear();
                textBox4_busArrivalLoc.Clear();
                textBox5_busTicketPrice.Clear();
                textBox6_busAvailableSeat.Clear();
                MessageBox.Show("update Successful");
                bindDataGird();
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void Bus_delete_Click(object sender, EventArgs e)
        {
            string query = "delete from busInfo where busId='" + textBox1_busId.Text + "'";

            SqlCommand cmd1 = new SqlCommand(query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd1.ExecuteNonQuery();
                textBox1_busId.Clear();
                textBox2_busName.Clear();
                textBox3_busDepartureLoc.Clear();
                textBox4_busArrivalLoc.Clear();
                textBox5_busTicketPrice.Clear();
                textBox6_busAvailableSeat.Clear();
                MessageBox.Show("Delete Successful");
                bindDataGird();
            }
            else
            {
                MessageBox.Show("Failed ");
            }
            con.Close();
        }

        
    }
}
