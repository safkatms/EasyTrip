
namespace TicketReservationSystem
{
    partial class Passenger
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
            this.comboBox1_Usr_gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_usrDOB = new System.Windows.Forms.DateTimePicker();
            this.button1_signup = new System.Windows.Forms.Button();
            this.User_lastName = new System.Windows.Forms.TextBox();
            this.User_userName = new System.Windows.Forms.TextBox();
            this.User_phn = new System.Windows.Forms.TextBox();
            this.User_email = new System.Windows.Forms.TextBox();
            this.User_firstName = new System.Windows.Forms.TextBox();
            this.label7_Gender = new System.Windows.Forms.Label();
            this.label6_DoB = new System.Windows.Forms.Label();
            this.label5_mobile = new System.Windows.Forms.Label();
            this.label4_email = new System.Windows.Forms.Label();
            this.label3_Username = new System.Windows.Forms.Label();
            this.label2_lastName = new System.Windows.Forms.Label();
            this.label1_firstName = new System.Windows.Forms.Label();
            this.label1_signUp = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label1_Password = new System.Windows.Forms.Label();
            this.button2_Clear = new System.Windows.Forms.Button();
            this.button3_Back = new System.Windows.Forms.Button();
            this.userShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1_Usr_gender
            // 
            this.comboBox1_Usr_gender.FormattingEnabled = true;
            this.comboBox1_Usr_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1_Usr_gender.Location = new System.Drawing.Point(61, 330);
            this.comboBox1_Usr_gender.Name = "comboBox1_Usr_gender";
            this.comboBox1_Usr_gender.Size = new System.Drawing.Size(275, 21);
            this.comboBox1_Usr_gender.TabIndex = 32;
            // 
            // dateTimePicker1_usrDOB
            // 
            this.dateTimePicker1_usrDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_usrDOB.Location = new System.Drawing.Point(61, 291);
            this.dateTimePicker1_usrDOB.Name = "dateTimePicker1_usrDOB";
            this.dateTimePicker1_usrDOB.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker1_usrDOB.TabIndex = 31;
            // 
            // button1_signup
            // 
            this.button1_signup.BackColor = System.Drawing.Color.MediumPurple;
            this.button1_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_signup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_signup.ForeColor = System.Drawing.Color.White;
            this.button1_signup.Location = new System.Drawing.Point(56, 421);
            this.button1_signup.Name = "button1_signup";
            this.button1_signup.Size = new System.Drawing.Size(280, 33);
            this.button1_signup.TabIndex = 30;
            this.button1_signup.Text = "Sign Up";
            this.button1_signup.UseVisualStyleBackColor = false;
            this.button1_signup.Click += new System.EventHandler(this.button1_signup_Click);
            // 
            // User_lastName
            // 
            this.User_lastName.Location = new System.Drawing.Point(61, 122);
            this.User_lastName.Name = "User_lastName";
            this.User_lastName.Size = new System.Drawing.Size(275, 20);
            this.User_lastName.TabIndex = 29;
            // 
            // User_userName
            // 
            this.User_userName.Location = new System.Drawing.Point(61, 165);
            this.User_userName.Name = "User_userName";
            this.User_userName.Size = new System.Drawing.Size(275, 20);
            this.User_userName.TabIndex = 28;
            // 
            // User_phn
            // 
            this.User_phn.Location = new System.Drawing.Point(61, 247);
            this.User_phn.Name = "User_phn";
            this.User_phn.Size = new System.Drawing.Size(275, 20);
            this.User_phn.TabIndex = 27;
            // 
            // User_email
            // 
            this.User_email.Location = new System.Drawing.Point(61, 206);
            this.User_email.Name = "User_email";
            this.User_email.Size = new System.Drawing.Size(275, 20);
            this.User_email.TabIndex = 26;
            // 
            // User_firstName
            // 
            this.User_firstName.Location = new System.Drawing.Point(61, 81);
            this.User_firstName.Name = "User_firstName";
            this.User_firstName.Size = new System.Drawing.Size(275, 20);
            this.User_firstName.TabIndex = 25;
            // 
            // label7_Gender
            // 
            this.label7_Gender.AutoSize = true;
            this.label7_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_Gender.Location = new System.Drawing.Point(58, 314);
            this.label7_Gender.Name = "label7_Gender";
            this.label7_Gender.Size = new System.Drawing.Size(54, 15);
            this.label7_Gender.TabIndex = 24;
            this.label7_Gender.Text = "Gender: ";
            // 
            // label6_DoB
            // 
            this.label6_DoB.AutoSize = true;
            this.label6_DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_DoB.Location = new System.Drawing.Point(58, 270);
            this.label6_DoB.Name = "label6_DoB";
            this.label6_DoB.Size = new System.Drawing.Size(80, 15);
            this.label6_DoB.TabIndex = 23;
            this.label6_DoB.Text = "Date of Birth: ";
            // 
            // label5_mobile
            // 
            this.label5_mobile.AutoSize = true;
            this.label5_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_mobile.Location = new System.Drawing.Point(58, 229);
            this.label5_mobile.Name = "label5_mobile";
            this.label5_mobile.Size = new System.Drawing.Size(97, 15);
            this.label5_mobile.TabIndex = 22;
            this.label5_mobile.Text = "Phone Number: ";
            // 
            // label4_email
            // 
            this.label4_email.AutoSize = true;
            this.label4_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_email.Location = new System.Drawing.Point(58, 188);
            this.label4_email.Name = "label4_email";
            this.label4_email.Size = new System.Drawing.Size(45, 15);
            this.label4_email.TabIndex = 21;
            this.label4_email.Text = "Email: ";
            // 
            // label3_Username
            // 
            this.label3_Username.AutoSize = true;
            this.label3_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_Username.Location = new System.Drawing.Point(58, 149);
            this.label3_Username.Name = "label3_Username";
            this.label3_Username.Size = new System.Drawing.Size(76, 15);
            this.label3_Username.TabIndex = 20;
            this.label3_Username.Text = "User Name: ";
            // 
            // label2_lastName
            // 
            this.label2_lastName.AutoSize = true;
            this.label2_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_lastName.Location = new System.Drawing.Point(58, 104);
            this.label2_lastName.Name = "label2_lastName";
            this.label2_lastName.Size = new System.Drawing.Size(73, 15);
            this.label2_lastName.TabIndex = 19;
            this.label2_lastName.Text = "Last Name: ";
            // 
            // label1_firstName
            // 
            this.label1_firstName.AutoSize = true;
            this.label1_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_firstName.Location = new System.Drawing.Point(58, 65);
            this.label1_firstName.Name = "label1_firstName";
            this.label1_firstName.Size = new System.Drawing.Size(73, 15);
            this.label1_firstName.TabIndex = 18;
            this.label1_firstName.Text = "First Name: ";
            // 
            // label1_signUp
            // 
            this.label1_signUp.AutoSize = true;
            this.label1_signUp.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_signUp.Location = new System.Drawing.Point(56, 27);
            this.label1_signUp.Name = "label1_signUp";
            this.label1_signUp.Size = new System.Drawing.Size(95, 28);
            this.label1_signUp.TabIndex = 17;
            this.label1_signUp.Text = "Sign Up";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(61, 372);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(275, 20);
            this.userPassword.TabIndex = 34;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // label1_Password
            // 
            this.label1_Password.AutoSize = true;
            this.label1_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Password.Location = new System.Drawing.Point(58, 354);
            this.label1_Password.Name = "label1_Password";
            this.label1_Password.Size = new System.Drawing.Size(67, 15);
            this.label1_Password.TabIndex = 33;
            this.label1_Password.Text = "Password: ";
            // 
            // button2_Clear
            // 
            this.button2_Clear.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Clear.Location = new System.Drawing.Point(269, 394);
            this.button2_Clear.Name = "button2_Clear";
            this.button2_Clear.Size = new System.Drawing.Size(67, 23);
            this.button2_Clear.TabIndex = 35;
            this.button2_Clear.Text = "Clear";
            this.button2_Clear.UseVisualStyleBackColor = true;
            this.button2_Clear.Click += new System.EventHandler(this.button2_Clear_Click);
            // 
            // button3_Back
            // 
            this.button3_Back.BackColor = System.Drawing.Color.MediumPurple;
            this.button3_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_Back.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Back.ForeColor = System.Drawing.Color.White;
            this.button3_Back.Location = new System.Drawing.Point(56, 495);
            this.button3_Back.Name = "button3_Back";
            this.button3_Back.Size = new System.Drawing.Size(280, 33);
            this.button3_Back.TabIndex = 36;
            this.button3_Back.Text = "Login";
            this.button3_Back.UseVisualStyleBackColor = false;
            this.button3_Back.Click += new System.EventHandler(this.button3_Back_Click);
            // 
            // userShowPass
            // 
            this.userShowPass.AutoSize = true;
            this.userShowPass.Location = new System.Drawing.Point(61, 398);
            this.userShowPass.Name = "userShowPass";
            this.userShowPass.Size = new System.Drawing.Size(102, 17);
            this.userShowPass.TabIndex = 37;
            this.userShowPass.Text = "Show Password";
            this.userShowPass.UseVisualStyleBackColor = true;
            this.userShowPass.CheckedChanged += new System.EventHandler(this.userShowPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "-----OR-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userShowPass);
            this.Controls.Add(this.button3_Back);
            this.Controls.Add(this.button2_Clear);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label1_Password);
            this.Controls.Add(this.comboBox1_Usr_gender);
            this.Controls.Add(this.dateTimePicker1_usrDOB);
            this.Controls.Add(this.button1_signup);
            this.Controls.Add(this.User_lastName);
            this.Controls.Add(this.User_userName);
            this.Controls.Add(this.User_phn);
            this.Controls.Add(this.User_email);
            this.Controls.Add(this.User_firstName);
            this.Controls.Add(this.label7_Gender);
            this.Controls.Add(this.label6_DoB);
            this.Controls.Add(this.label5_mobile);
            this.Controls.Add(this.label4_email);
            this.Controls.Add(this.label3_Username);
            this.Controls.Add(this.label2_lastName);
            this.Controls.Add(this.label1_firstName);
            this.Controls.Add(this.label1_signUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_Usr_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_usrDOB;
        private System.Windows.Forms.Button button1_signup;
        private System.Windows.Forms.TextBox User_lastName;
        private System.Windows.Forms.TextBox User_userName;
        private System.Windows.Forms.TextBox User_phn;
        private System.Windows.Forms.TextBox User_email;
        private System.Windows.Forms.TextBox User_firstName;
        private System.Windows.Forms.Label label7_Gender;
        private System.Windows.Forms.Label label6_DoB;
        private System.Windows.Forms.Label label5_mobile;
        private System.Windows.Forms.Label label4_email;
        private System.Windows.Forms.Label label3_Username;
        private System.Windows.Forms.Label label2_lastName;
        private System.Windows.Forms.Label label1_firstName;
        private System.Windows.Forms.Label label1_signUp;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label1_Password;
        private System.Windows.Forms.Button button2_Clear;
        private System.Windows.Forms.Button button3_Back;
        private System.Windows.Forms.CheckBox userShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}