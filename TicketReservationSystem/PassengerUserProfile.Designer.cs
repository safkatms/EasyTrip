
namespace TicketReservationSystem
{
    partial class PassengerUserProfile
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
            this.userShowPass = new System.Windows.Forms.CheckBox();
            this.user_dob = new System.Windows.Forms.TextBox();
            this.user_gender = new System.Windows.Forms.TextBox();
            this.profileSave = new System.Windows.Forms.Button();
            this.profileUpdate = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label8_password = new System.Windows.Forms.Label();
            this.User_lastName = new System.Windows.Forms.TextBox();
            this.User_userName = new System.Windows.Forms.TextBox();
            this.User_phn = new System.Windows.Forms.TextBox();
            this.User_email = new System.Windows.Forms.TextBox();
            this.User_firstName = new System.Windows.Forms.TextBox();
            this.label7_Admin_Gender = new System.Windows.Forms.Label();
            this.label6_Admin_DoB = new System.Windows.Forms.Label();
            this.label5_Admin_mobile = new System.Windows.Forms.Label();
            this.label4_Admin_email = new System.Windows.Forms.Label();
            this.label3_Admin_Username = new System.Windows.Forms.Label();
            this.label2_Admin_lastName = new System.Windows.Forms.Label();
            this.label1_Admin_firstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userShowPass
            // 
            this.userShowPass.AutoSize = true;
            this.userShowPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userShowPass.Location = new System.Drawing.Point(237, 368);
            this.userShowPass.Name = "userShowPass";
            this.userShowPass.Size = new System.Drawing.Size(109, 20);
            this.userShowPass.TabIndex = 90;
            this.userShowPass.Text = "Show Password";
            this.userShowPass.UseVisualStyleBackColor = true;
            this.userShowPass.CheckedChanged += new System.EventHandler(this.userShowPass_CheckedChanged);
            // 
            // user_dob
            // 
            this.user_dob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_dob.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_dob.Location = new System.Drawing.Point(237, 257);
            this.user_dob.Name = "user_dob";
            this.user_dob.ReadOnly = true;
            this.user_dob.Size = new System.Drawing.Size(175, 22);
            this.user_dob.TabIndex = 89;
            // 
            // user_gender
            // 
            this.user_gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_gender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_gender.Location = new System.Drawing.Point(237, 293);
            this.user_gender.Name = "user_gender";
            this.user_gender.ReadOnly = true;
            this.user_gender.Size = new System.Drawing.Size(175, 22);
            this.user_gender.TabIndex = 88;
            // 
            // profileSave
            // 
            this.profileSave.BackColor = System.Drawing.Color.MediumPurple;
            this.profileSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileSave.ForeColor = System.Drawing.Color.White;
            this.profileSave.Location = new System.Drawing.Point(318, 404);
            this.profileSave.Name = "profileSave";
            this.profileSave.Size = new System.Drawing.Size(94, 28);
            this.profileSave.TabIndex = 87;
            this.profileSave.Text = "Save";
            this.profileSave.UseVisualStyleBackColor = false;
            this.profileSave.Visible = false;
            this.profileSave.Click += new System.EventHandler(this.profileSave_Click);
            // 
            // profileUpdate
            // 
            this.profileUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.profileUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUpdate.ForeColor = System.Drawing.Color.White;
            this.profileUpdate.Location = new System.Drawing.Point(90, 404);
            this.profileUpdate.Name = "profileUpdate";
            this.profileUpdate.Size = new System.Drawing.Size(94, 28);
            this.profileUpdate.TabIndex = 86;
            this.profileUpdate.Text = "Update";
            this.profileUpdate.UseVisualStyleBackColor = false;
            this.profileUpdate.Click += new System.EventHandler(this.profileUpdate_Click);
            // 
            // userPassword
            // 
            this.userPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(237, 333);
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.Size = new System.Drawing.Size(175, 22);
            this.userPassword.TabIndex = 85;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // label8_password
            // 
            this.label8_password.AutoSize = true;
            this.label8_password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_password.Location = new System.Drawing.Point(86, 333);
            this.label8_password.Name = "label8_password";
            this.label8_password.Size = new System.Drawing.Size(91, 21);
            this.label8_password.TabIndex = 84;
            this.label8_password.Text = "Password: ";
            // 
            // User_lastName
            // 
            this.User_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_lastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_lastName.Location = new System.Drawing.Point(237, 80);
            this.User_lastName.Name = "User_lastName";
            this.User_lastName.ReadOnly = true;
            this.User_lastName.Size = new System.Drawing.Size(175, 22);
            this.User_lastName.TabIndex = 83;
            // 
            // User_userName
            // 
            this.User_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_userName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_userName.Location = new System.Drawing.Point(237, 125);
            this.User_userName.Name = "User_userName";
            this.User_userName.ReadOnly = true;
            this.User_userName.Size = new System.Drawing.Size(175, 22);
            this.User_userName.TabIndex = 82;
            // 
            // User_phn
            // 
            this.User_phn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_phn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_phn.Location = new System.Drawing.Point(237, 213);
            this.User_phn.Name = "User_phn";
            this.User_phn.ReadOnly = true;
            this.User_phn.Size = new System.Drawing.Size(175, 22);
            this.User_phn.TabIndex = 81;
            // 
            // User_email
            // 
            this.User_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_email.Location = new System.Drawing.Point(237, 168);
            this.User_email.Name = "User_email";
            this.User_email.ReadOnly = true;
            this.User_email.Size = new System.Drawing.Size(175, 22);
            this.User_email.TabIndex = 80;
            // 
            // User_firstName
            // 
            this.User_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_firstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_firstName.Location = new System.Drawing.Point(237, 41);
            this.User_firstName.Name = "User_firstName";
            this.User_firstName.ReadOnly = true;
            this.User_firstName.Size = new System.Drawing.Size(175, 22);
            this.User_firstName.TabIndex = 79;
            // 
            // label7_Admin_Gender
            // 
            this.label7_Admin_Gender.AutoSize = true;
            this.label7_Admin_Gender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_Admin_Gender.Location = new System.Drawing.Point(86, 293);
            this.label7_Admin_Gender.Name = "label7_Admin_Gender";
            this.label7_Admin_Gender.Size = new System.Drawing.Size(75, 21);
            this.label7_Admin_Gender.TabIndex = 78;
            this.label7_Admin_Gender.Text = "Gender: ";
            // 
            // label6_Admin_DoB
            // 
            this.label6_Admin_DoB.AutoSize = true;
            this.label6_Admin_DoB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_Admin_DoB.Location = new System.Drawing.Point(86, 257);
            this.label6_Admin_DoB.Name = "label6_Admin_DoB";
            this.label6_Admin_DoB.Size = new System.Drawing.Size(117, 21);
            this.label6_Admin_DoB.TabIndex = 77;
            this.label6_Admin_DoB.Text = "Date of Birth: ";
            // 
            // label5_Admin_mobile
            // 
            this.label5_Admin_mobile.AutoSize = true;
            this.label5_Admin_mobile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_Admin_mobile.Location = new System.Drawing.Point(86, 213);
            this.label5_Admin_mobile.Name = "label5_Admin_mobile";
            this.label5_Admin_mobile.Size = new System.Drawing.Size(136, 21);
            this.label5_Admin_mobile.TabIndex = 76;
            this.label5_Admin_mobile.Text = "Phone Number: ";
            // 
            // label4_Admin_email
            // 
            this.label4_Admin_email.AutoSize = true;
            this.label4_Admin_email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_Admin_email.Location = new System.Drawing.Point(86, 168);
            this.label4_Admin_email.Name = "label4_Admin_email";
            this.label4_Admin_email.Size = new System.Drawing.Size(60, 21);
            this.label4_Admin_email.TabIndex = 75;
            this.label4_Admin_email.Text = "Email: ";
            // 
            // label3_Admin_Username
            // 
            this.label3_Admin_Username.AutoSize = true;
            this.label3_Admin_Username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_Admin_Username.Location = new System.Drawing.Point(86, 125);
            this.label3_Admin_Username.Name = "label3_Admin_Username";
            this.label3_Admin_Username.Size = new System.Drawing.Size(104, 21);
            this.label3_Admin_Username.TabIndex = 74;
            this.label3_Admin_Username.Text = "User Name: ";
            // 
            // label2_Admin_lastName
            // 
            this.label2_Admin_lastName.AutoSize = true;
            this.label2_Admin_lastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Admin_lastName.Location = new System.Drawing.Point(86, 80);
            this.label2_Admin_lastName.Name = "label2_Admin_lastName";
            this.label2_Admin_lastName.Size = new System.Drawing.Size(100, 21);
            this.label2_Admin_lastName.TabIndex = 73;
            this.label2_Admin_lastName.Text = "Last Name: ";
            // 
            // label1_Admin_firstName
            // 
            this.label1_Admin_firstName.AutoSize = true;
            this.label1_Admin_firstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Admin_firstName.Location = new System.Drawing.Point(86, 41);
            this.label1_Admin_firstName.Name = "label1_Admin_firstName";
            this.label1_Admin_firstName.Size = new System.Drawing.Size(102, 21);
            this.label1_Admin_firstName.TabIndex = 72;
            this.label1_Admin_firstName.Text = "First Name: ";
            // 
            // PassengerUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.userShowPass);
            this.Controls.Add(this.user_dob);
            this.Controls.Add(this.user_gender);
            this.Controls.Add(this.profileSave);
            this.Controls.Add(this.profileUpdate);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label8_password);
            this.Controls.Add(this.User_lastName);
            this.Controls.Add(this.User_userName);
            this.Controls.Add(this.User_phn);
            this.Controls.Add(this.User_email);
            this.Controls.Add(this.User_firstName);
            this.Controls.Add(this.label7_Admin_Gender);
            this.Controls.Add(this.label6_Admin_DoB);
            this.Controls.Add(this.label5_Admin_mobile);
            this.Controls.Add(this.label4_Admin_email);
            this.Controls.Add(this.label3_Admin_Username);
            this.Controls.Add(this.label2_Admin_lastName);
            this.Controls.Add(this.label1_Admin_firstName);
            this.Name = "PassengerUserProfile";
            this.Size = new System.Drawing.Size(679, 572);
            this.Load += new System.EventHandler(this.PassengerUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox userShowPass;
        private System.Windows.Forms.TextBox user_dob;
        private System.Windows.Forms.TextBox user_gender;
        private System.Windows.Forms.Button profileSave;
        private System.Windows.Forms.Button profileUpdate;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label8_password;
        private System.Windows.Forms.TextBox User_lastName;
        private System.Windows.Forms.TextBox User_userName;
        private System.Windows.Forms.TextBox User_phn;
        private System.Windows.Forms.TextBox User_email;
        private System.Windows.Forms.TextBox User_firstName;
        private System.Windows.Forms.Label label7_Admin_Gender;
        private System.Windows.Forms.Label label6_Admin_DoB;
        private System.Windows.Forms.Label label5_Admin_mobile;
        private System.Windows.Forms.Label label4_Admin_email;
        private System.Windows.Forms.Label label3_Admin_Username;
        private System.Windows.Forms.Label label2_Admin_lastName;
        private System.Windows.Forms.Label label1_Admin_firstName;
    }
}
