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
    public partial class BookBus : UserControl
    {
        public BookBus()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SAKIBS-ZENBOOK\\SQLEXPRESS;Initial Catalog=EasyTrip;Integrated Security=True");
        private void BookBus_Load(object sender, EventArgs e)
        {
            FillComboBox();
            textBox1_busUN.Text = LoggedInUserDetails.userName;
        }


        private void button1_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            bindDataGird();
        }
        public void bindDataGird() // will show match result in data grid
        {
            string departure, arrival;



            departure = comboBox_busDepart.Text;
            arrival = comboBox_busArrival.Text;

            string query = "select* from busInfo where busDepartureLoc ='" + departure + "'and busArrivalLoc= '" + arrival + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);



            DataTable dt = new DataTable();
            sda.Fill(dt);



            dataGridView1.DataSource = dt;
        }

        private void button2_Clear_Click(object sender, EventArgs e)
        {
            comboBox_busDepart.Text = string.Empty;
            comboBox_busArrival.Text = string.Empty;
        }

        public void FillComboBox()
        {
            string query = "select* from busInfo";






            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            sda.Fill(d);



            foreach (DataRow dr in d.Rows)
            {
                comboBox_busDepart.Items.Add(dr["busDepartureLoc"].ToString());
                comboBox_busArrival.Items.Add(dr["busArrivalLoc"].ToString());
            }


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2_busId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3_busN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4_busDl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5_busAL.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6_busDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox8_busTP.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();



            panel2_TicketDetails.Visible = true;
            panel1_busSeat.Visible = true;
        }
        private void button_BusSeat(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string busid = textBox2_busId.Text;
            ////
            string query1 = "insert into busSeat values ('" + busid + "','" + b.Text + "')";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();
                //textBox7_BusSN.Text = b.Text;
                b.BackColor = Color.Gray;
                Confirm.Enabled = true;
            }
            con.Close();
            ////

            ////
            string query2 = "select BusSeatNo from busSeat where BusId='" + busid + "'";

            SqlCommand cm = new SqlCommand(query2, con);
            con.Open();
            SqlDataReader rd;
            rd = cm.ExecuteReader();
            while (rd.Read())
            {
                textBox7_BusSN.Text = rd.GetValue(0).ToString();
            }
            con.Close();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2_busId.Clear();
            textBox3_busN.Clear();
            textBox4_busDl.Clear();
            textBox5_busAL.Clear();
            textBox6_busDT.Clear();
            textBox7_BusSN.Clear();
            textBox8_busTP.Clear();
            panel1_busSeat.Visible = false;
            panel2_TicketDetails.Visible = false;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string busSeatNo = textBox7_BusSN.Text;
            con.Open();
            string query = "select BusSeatNo from busTicketInfo where BusSeatNo= '" + busSeatNo + "'";

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
                string query1 = "insert into busTicketInfo values('" + textBox1_busUN.Text + "','" + textBox2_busId.Text + "','" + textBox3_busN.Text + "','" + textBox4_busDl.Text + "','" + textBox5_busAL.Text + "','" + textBox6_busDT.Text + "','" + textBox7_BusSN.Text + "','" + textBox8_busTP.Text + "')";

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

        private void panel2_TicketDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
