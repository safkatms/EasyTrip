
namespace TicketReservationSystem
{
    partial class UserControl_Air
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1_air = new System.Windows.Forms.DataGridView();
            this.add_air = new System.Windows.Forms.Button();
            this.button5_Details = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.air_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_airId = new System.Windows.Forms.TextBox();
            this.textBox2_airName = new System.Windows.Forms.TextBox();
            this.textBox3_airDepartLoc = new System.Windows.Forms.TextBox();
            this.textBox4_airArrivalLoc = new System.Windows.Forms.TextBox();
            this.textBox5_airTicketPrice = new System.Windows.Forms.TextBox();
            this.textBox6_airAvailableSeat = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_airDepartTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_air)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_air
            // 
            this.dataGridView1_air.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1_air.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_air.Location = new System.Drawing.Point(3, 238);
            this.dataGridView1_air.Name = "dataGridView1_air";
            this.dataGridView1_air.Size = new System.Drawing.Size(673, 331);
            this.dataGridView1_air.TabIndex = 28;
            this.dataGridView1_air.Visible = false;
            this.dataGridView1_air.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_air_CellMouseDoubleClick);
            // 
            // add_air
            // 
            this.add_air.BackColor = System.Drawing.Color.MediumPurple;
            this.add_air.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_air.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_air.ForeColor = System.Drawing.Color.White;
            this.add_air.Location = new System.Drawing.Point(582, 69);
            this.add_air.Name = "add_air";
            this.add_air.Size = new System.Drawing.Size(75, 38);
            this.add_air.TabIndex = 27;
            this.add_air.Text = "Add";
            this.add_air.UseVisualStyleBackColor = false;
            this.add_air.Click += new System.EventHandler(this.add_air_Click);
            // 
            // button5_Details
            // 
            this.button5_Details.BackColor = System.Drawing.Color.MediumPurple;
            this.button5_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_Details.ForeColor = System.Drawing.Color.White;
            this.button5_Details.Location = new System.Drawing.Point(582, 120);
            this.button5_Details.Name = "button5_Details";
            this.button5_Details.Size = new System.Drawing.Size(75, 38);
            this.button5_Details.TabIndex = 26;
            this.button5_Details.Text = "Details";
            this.button5_Details.UseVisualStyleBackColor = false;
            this.button5_Details.Click += new System.EventHandler(this.button5_Details_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.MediumPurple;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(582, 171);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 38);
            this.Update.TabIndex = 25;
            this.Update.Text = "Update ";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // air_delete
            // 
            this.air_delete.BackColor = System.Drawing.Color.MediumPurple;
            this.air_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.air_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.air_delete.ForeColor = System.Drawing.Color.White;
            this.air_delete.Location = new System.Drawing.Point(582, 24);
            this.air_delete.Name = "air_delete";
            this.air_delete.Size = new System.Drawing.Size(75, 38);
            this.air_delete.TabIndex = 24;
            this.air_delete.Text = "Delete";
            this.air_delete.UseVisualStyleBackColor = false;
            this.air_delete.Click += new System.EventHandler(this.air_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(66, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Air ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(66, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Air Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(66, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Air Departure Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(66, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Air Arrival Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(66, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Air Departure Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(66, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Air Ticket Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.Location = new System.Drawing.Point(66, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Air Available Seat:";
            // 
            // textBox1_airId
            // 
            this.textBox1_airId.Location = new System.Drawing.Point(261, 14);
            this.textBox1_airId.Name = "textBox1_airId";
            this.textBox1_airId.Size = new System.Drawing.Size(232, 20);
            this.textBox1_airId.TabIndex = 36;
            // 
            // textBox2_airName
            // 
            this.textBox2_airName.Location = new System.Drawing.Point(261, 42);
            this.textBox2_airName.Name = "textBox2_airName";
            this.textBox2_airName.Size = new System.Drawing.Size(232, 20);
            this.textBox2_airName.TabIndex = 37;
            // 
            // textBox3_airDepartLoc
            // 
            this.textBox3_airDepartLoc.Location = new System.Drawing.Point(261, 72);
            this.textBox3_airDepartLoc.Name = "textBox3_airDepartLoc";
            this.textBox3_airDepartLoc.Size = new System.Drawing.Size(232, 20);
            this.textBox3_airDepartLoc.TabIndex = 38;
            // 
            // textBox4_airArrivalLoc
            // 
            this.textBox4_airArrivalLoc.Location = new System.Drawing.Point(261, 103);
            this.textBox4_airArrivalLoc.Name = "textBox4_airArrivalLoc";
            this.textBox4_airArrivalLoc.Size = new System.Drawing.Size(232, 20);
            this.textBox4_airArrivalLoc.TabIndex = 39;
            // 
            // textBox5_airTicketPrice
            // 
            this.textBox5_airTicketPrice.Location = new System.Drawing.Point(261, 166);
            this.textBox5_airTicketPrice.Name = "textBox5_airTicketPrice";
            this.textBox5_airTicketPrice.Size = new System.Drawing.Size(232, 20);
            this.textBox5_airTicketPrice.TabIndex = 40;
            // 
            // textBox6_airAvailableSeat
            // 
            this.textBox6_airAvailableSeat.Location = new System.Drawing.Point(261, 201);
            this.textBox6_airAvailableSeat.Name = "textBox6_airAvailableSeat";
            this.textBox6_airAvailableSeat.Size = new System.Drawing.Size(232, 20);
            this.textBox6_airAvailableSeat.TabIndex = 41;
            // 
            // dateTimePicker1_airDepartTime
            // 
            this.dateTimePicker1_airDepartTime.Location = new System.Drawing.Point(261, 135);
            this.dateTimePicker1_airDepartTime.Name = "dateTimePicker1_airDepartTime";
            this.dateTimePicker1_airDepartTime.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1_airDepartTime.TabIndex = 42;
            // 
            // UserControl_Air
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker1_airDepartTime);
            this.Controls.Add(this.textBox6_airAvailableSeat);
            this.Controls.Add(this.textBox5_airTicketPrice);
            this.Controls.Add(this.textBox4_airArrivalLoc);
            this.Controls.Add(this.textBox3_airDepartLoc);
            this.Controls.Add(this.textBox2_airName);
            this.Controls.Add(this.textBox1_airId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_air);
            this.Controls.Add(this.add_air);
            this.Controls.Add(this.button5_Details);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.air_delete);
            this.Name = "UserControl_Air";
            this.Size = new System.Drawing.Size(679, 572);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_air)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_air;
        private System.Windows.Forms.Button add_air;
        private System.Windows.Forms.Button button5_Details;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button air_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1_airId;
        private System.Windows.Forms.TextBox textBox2_airName;
        private System.Windows.Forms.TextBox textBox3_airDepartLoc;
        private System.Windows.Forms.TextBox textBox4_airArrivalLoc;
        private System.Windows.Forms.TextBox textBox5_airTicketPrice;
        private System.Windows.Forms.TextBox textBox6_airAvailableSeat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_airDepartTime;
    }
}
