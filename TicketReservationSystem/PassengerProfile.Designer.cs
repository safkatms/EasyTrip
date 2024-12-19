
namespace TicketReservationSystem
{
    partial class PassengerProfile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_Home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.airTickets = new System.Windows.Forms.Button();
            this.busTickets = new System.Windows.Forms.Button();
            this.user_logout = new System.Windows.Forms.Button();
            this.button2_air = new System.Windows.Forms.Button();
            this.button1_bus = new System.Windows.Forms.Button();
            this.button1_book = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.button5_ticketDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.airTicketd = new System.Windows.Forms.Label();
            this.busTicketd = new System.Windows.Forms.Label();
            this.Air = new System.Windows.Forms.Label();
            this.Bus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.busTickets1 = new TicketReservationSystem.BusTickets();
            this.airTickets1 = new TicketReservationSystem.AirTickets();
            this.passengerUserProfile1 = new TicketReservationSystem.PassengerUserProfile();
            this.bookAir1 = new TicketReservationSystem.BookAir();
            this.bookBus1 = new TicketReservationSystem.BookBus();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Home
            // 
            this.label1_Home.AutoSize = true;
            this.label1_Home.BackColor = System.Drawing.Color.White;
            this.label1_Home.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Home.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1_Home.Location = new System.Drawing.Point(269, 34);
            this.label1_Home.Name = "label1_Home";
            this.label1_Home.Size = new System.Drawing.Size(118, 25);
            this.label1_Home.TabIndex = 0;
            this.label1_Home.Text = "User Profile";
            this.label1_Home.Click += new System.EventHandler(this.label1air_Profile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.airTickets);
            this.panel1.Controls.Add(this.busTickets);
            this.panel1.Controls.Add(this.user_logout);
            this.panel1.Controls.Add(this.button2_air);
            this.panel1.Controls.Add(this.button1_bus);
            this.panel1.Controls.Add(this.button1_book);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.button5_ticketDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 632);
            this.panel1.TabIndex = 6;
            // 
            // airTickets
            // 
            this.airTickets.BackColor = System.Drawing.Color.MediumPurple;
            this.airTickets.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airTickets.ForeColor = System.Drawing.Color.White;
            this.airTickets.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__9_;
            this.airTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.airTickets.Location = new System.Drawing.Point(100, 409);
            this.airTickets.Margin = new System.Windows.Forms.Padding(2);
            this.airTickets.Name = "airTickets";
            this.airTickets.Size = new System.Drawing.Size(100, 75);
            this.airTickets.TabIndex = 10;
            this.airTickets.Text = "Air";
            this.airTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.airTickets.UseVisualStyleBackColor = false;
            this.airTickets.Visible = false;
            this.airTickets.Click += new System.EventHandler(this.airTickets_Click);
            // 
            // busTickets
            // 
            this.busTickets.BackColor = System.Drawing.Color.MediumPurple;
            this.busTickets.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busTickets.ForeColor = System.Drawing.Color.White;
            this.busTickets.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__7__removebg_preview;
            this.busTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busTickets.Location = new System.Drawing.Point(3, 409);
            this.busTickets.Margin = new System.Windows.Forms.Padding(2);
            this.busTickets.Name = "busTickets";
            this.busTickets.Size = new System.Drawing.Size(100, 75);
            this.busTickets.TabIndex = 9;
            this.busTickets.Text = "Bus";
            this.busTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.busTickets.UseVisualStyleBackColor = false;
            this.busTickets.Visible = false;
            this.busTickets.Click += new System.EventHandler(this.busTickets_Click);
            // 
            // user_logout
            // 
            this.user_logout.BackColor = System.Drawing.Color.White;
            this.user_logout.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__12_;
            this.user_logout.Location = new System.Drawing.Point(3, 587);
            this.user_logout.Margin = new System.Windows.Forms.Padding(2);
            this.user_logout.Name = "user_logout";
            this.user_logout.Size = new System.Drawing.Size(45, 45);
            this.user_logout.TabIndex = 9;
            this.user_logout.UseVisualStyleBackColor = false;
            this.user_logout.Click += new System.EventHandler(this.user_logout_Click);
            // 
            // button2_air
            // 
            this.button2_air.BackColor = System.Drawing.Color.MediumPurple;
            this.button2_air.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_air.ForeColor = System.Drawing.Color.White;
            this.button2_air.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__9_;
            this.button2_air.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_air.Location = new System.Drawing.Point(100, 249);
            this.button2_air.Margin = new System.Windows.Forms.Padding(2);
            this.button2_air.Name = "button2_air";
            this.button2_air.Size = new System.Drawing.Size(100, 75);
            this.button2_air.TabIndex = 8;
            this.button2_air.Text = "Air";
            this.button2_air.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2_air.UseVisualStyleBackColor = false;
            this.button2_air.Visible = false;
            this.button2_air.Click += new System.EventHandler(this.button2_air_Click);
            // 
            // button1_bus
            // 
            this.button1_bus.BackColor = System.Drawing.Color.MediumPurple;
            this.button1_bus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_bus.ForeColor = System.Drawing.Color.White;
            this.button1_bus.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__7__removebg_preview;
            this.button1_bus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_bus.Location = new System.Drawing.Point(3, 249);
            this.button1_bus.Margin = new System.Windows.Forms.Padding(2);
            this.button1_bus.Name = "button1_bus";
            this.button1_bus.Size = new System.Drawing.Size(100, 75);
            this.button1_bus.TabIndex = 7;
            this.button1_bus.Text = "Bus";
            this.button1_bus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_bus.UseVisualStyleBackColor = false;
            this.button1_bus.Visible = false;
            this.button1_bus.Click += new System.EventHandler(this.button1_bus_Click);
            // 
            // button1_book
            // 
            this.button1_book.BackColor = System.Drawing.Color.MediumPurple;
            this.button1_book.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_book.ForeColor = System.Drawing.Color.White;
            this.button1_book.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__15_;
            this.button1_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_book.Location = new System.Drawing.Point(3, 169);
            this.button1_book.Name = "button1_book";
            this.button1_book.Size = new System.Drawing.Size(200, 75);
            this.button1_book.TabIndex = 6;
            this.button1_book.Text = "Book Ticket";
            this.button1_book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_book.UseVisualStyleBackColor = false;
            this.button1_book.Click += new System.EventHandler(this.button1_book_Click);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.MediumPurple;
            this.Profile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.White;
            this.Profile.Image = global::TicketReservationSystem.Properties.Resources.MicrosoftTeams_image__14_;
            this.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.Location = new System.Drawing.Point(3, 88);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(200, 75);
            this.Profile.TabIndex = 3;
            this.Profile.Text = "Profile";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // button5_ticketDetails
            // 
            this.button5_ticketDetails.BackColor = System.Drawing.Color.MediumPurple;
            this.button5_ticketDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_ticketDetails.ForeColor = System.Drawing.Color.White;
            this.button5_ticketDetails.Image = global::TicketReservationSystem.Properties.Resources.ti_removebg_preview;
            this.button5_ticketDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5_ticketDetails.Location = new System.Drawing.Point(3, 329);
            this.button5_ticketDetails.Name = "button5_ticketDetails";
            this.button5_ticketDetails.Size = new System.Drawing.Size(200, 75);
            this.button5_ticketDetails.TabIndex = 5;
            this.button5_ticketDetails.Text = "Ticket Details";
            this.button5_ticketDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5_ticketDetails.UseVisualStyleBackColor = false;
            this.button5_ticketDetails.Click += new System.EventHandler(this.button5_ticketDetails_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.airTicketd);
            this.panel2.Controls.Add(this.busTicketd);
            this.panel2.Controls.Add(this.Air);
            this.panel2.Controls.Add(this.Bus);
            this.panel2.Controls.Add(this.label1_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 61);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // airTicketd
            // 
            this.airTicketd.AutoSize = true;
            this.airTicketd.BackColor = System.Drawing.Color.White;
            this.airTicketd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airTicketd.ForeColor = System.Drawing.Color.MediumPurple;
            this.airTicketd.Location = new System.Drawing.Point(249, 34);
            this.airTicketd.Name = "airTicketd";
            this.airTicketd.Size = new System.Drawing.Size(165, 25);
            this.airTicketd.TabIndex = 11;
            this.airTicketd.Text = "Air Ticket Details";
            this.airTicketd.Visible = false;
            // 
            // busTicketd
            // 
            this.busTicketd.AutoSize = true;
            this.busTicketd.BackColor = System.Drawing.Color.White;
            this.busTicketd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busTicketd.ForeColor = System.Drawing.Color.MediumPurple;
            this.busTicketd.Location = new System.Drawing.Point(249, 33);
            this.busTicketd.Name = "busTicketd";
            this.busTicketd.Size = new System.Drawing.Size(173, 25);
            this.busTicketd.TabIndex = 10;
            this.busTicketd.Text = "Bus Ticket Details";
            this.busTicketd.Visible = false;
            // 
            // Air
            // 
            this.Air.AutoSize = true;
            this.Air.BackColor = System.Drawing.Color.White;
            this.Air.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Air.ForeColor = System.Drawing.Color.MediumPurple;
            this.Air.Location = new System.Drawing.Point(323, 34);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(37, 25);
            this.Air.TabIndex = 2;
            this.Air.Text = "Air";
            this.Air.Visible = false;
            // 
            // Bus
            // 
            this.Bus.AutoSize = true;
            this.Bus.BackColor = System.Drawing.Color.White;
            this.Bus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bus.ForeColor = System.Drawing.Color.MediumPurple;
            this.Bus.Location = new System.Drawing.Point(315, 33);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(45, 25);
            this.Bus.TabIndex = 1;
            this.Bus.Text = "Bus";
            this.Bus.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 571);
            this.panel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(198, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To EasyTrip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::TicketReservationSystem.Properties.Resources._8493;
            this.pictureBox1.Location = new System.Drawing.Point(0, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // busTickets1
            // 
            this.busTickets1.BackColor = System.Drawing.Color.White;
            this.busTickets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busTickets1.Location = new System.Drawing.Point(200, 61);
            this.busTickets1.Name = "busTickets1";
            this.busTickets1.Size = new System.Drawing.Size(679, 571);
            this.busTickets1.TabIndex = 12;
            this.busTickets1.Visible = false;
            // 
            // airTickets1
            // 
            this.airTickets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airTickets1.Location = new System.Drawing.Point(200, 61);
            this.airTickets1.Name = "airTickets1";
            this.airTickets1.Size = new System.Drawing.Size(679, 571);
            this.airTickets1.TabIndex = 11;
            this.airTickets1.Visible = false;
            // 
            // passengerUserProfile1
            // 
            this.passengerUserProfile1.BackColor = System.Drawing.Color.White;
            this.passengerUserProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerUserProfile1.Location = new System.Drawing.Point(200, 61);
            this.passengerUserProfile1.Name = "passengerUserProfile1";
            this.passengerUserProfile1.Size = new System.Drawing.Size(679, 571);
            this.passengerUserProfile1.TabIndex = 10;
            this.passengerUserProfile1.Visible = false;
            // 
            // bookAir1
            // 
            this.bookAir1.BackColor = System.Drawing.Color.White;
            this.bookAir1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAir1.Location = new System.Drawing.Point(200, 61);
            this.bookAir1.Name = "bookAir1";
            this.bookAir1.Size = new System.Drawing.Size(679, 571);
            this.bookAir1.TabIndex = 9;
            this.bookAir1.Visible = false;
            // 
            // bookBus1
            // 
            this.bookBus1.BackColor = System.Drawing.Color.White;
            this.bookBus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookBus1.Location = new System.Drawing.Point(200, 61);
            this.bookBus1.Margin = new System.Windows.Forms.Padding(1);
            this.bookBus1.Name = "bookBus1";
            this.bookBus1.Size = new System.Drawing.Size(679, 571);
            this.bookBus1.TabIndex = 8;
            this.bookBus1.Visible = false;
            // 
            // PassengerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.busTickets1);
            this.Controls.Add(this.airTickets1);
            this.Controls.Add(this.passengerUserProfile1);
            this.Controls.Add(this.bookAir1);
            this.Controls.Add(this.bookBus1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassengerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerProfile";
            this.Activated += new System.EventHandler(this.PassengerProfile_Activated);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_Home;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button button5_ticketDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2_air;
        private System.Windows.Forms.Button button1_bus;
        private System.Windows.Forms.Button button1_book;
        private BookBus bookBus1;
        private BookAir bookAir1;
        private System.Windows.Forms.Label Air;
        private System.Windows.Forms.Label Bus;
        private System.Windows.Forms.Button user_logout;
        private PassengerUserProfile passengerUserProfile1;
        private System.Windows.Forms.Button airTickets;
        private System.Windows.Forms.Button busTickets;
        private AirTickets airTickets1;
        private BusTickets busTickets1;
        private System.Windows.Forms.Label airTicketd;
        private System.Windows.Forms.Label busTicketd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}