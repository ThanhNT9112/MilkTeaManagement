namespace MilkTea
{
    partial class AdminProfile
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            dtDob = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            label11 = new Label();
            label12 = new Label();
            txtNewPass = new TextBox();
            txtReNewPass = new TextBox();
            btnSave = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnTogglePassword = new Button();
            btnUpdateAccount = new Button();
            btnCancel = new Button();
            btnCancelAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(421, 27);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Manager Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 182);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 247);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 4;
            label5.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 315);
            label6.Name = "label6";
            label6.Size = new Size(78, 31);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 456);
            label7.Name = "label7";
            label7.Size = new Size(97, 31);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 383);
            label8.Name = "label8";
            label8.Size = new Size(70, 31);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.Location = new Point(158, 189);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(64, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.Location = new Point(248, 189);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(79, 24);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtDob
            // 
            dtDob.CustomFormat = "dd/MM/yyyy";
            dtDob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtDob.Format = DateTimePickerFormat.Custom;
            dtDob.Location = new Point(158, 251);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(250, 27);
            dtDob.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(158, 318);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 387);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 460);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(464, 116);
            label9.Name = "label9";
            label9.Size = new Size(98, 31);
            label9.TabIndex = 15;
            label9.Text = "Account";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(464, 182);
            label10.Name = "label10";
            label10.Size = new Size(110, 31);
            label10.TabIndex = 16;
            label10.Text = "Password";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(635, 122);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(250, 27);
            txtAccount.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(635, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(48, 559);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 60);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update Manager";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(444, 247);
            label11.Name = "label11";
            label11.Size = new Size(162, 31);
            label11.TabIndex = 20;
            label11.Text = "New Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(444, 315);
            label12.Name = "label12";
            label12.Size = new Size(183, 31);
            label12.TabIndex = 21;
            label12.Text = "Renew Password";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(635, 251);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(250, 27);
            txtNewPass.TabIndex = 22;
            // 
            // txtReNewPass
            // 
            txtReNewPass.Location = new Point(635, 319);
            txtReNewPass.Name = "txtReNewPass";
            txtReNewPass.Size = new Size(250, 27);
            txtReNewPass.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(708, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 70);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save Change Password";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = SystemColors.Info;
            btnTogglePassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTogglePassword.Location = new Point(891, 188);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(54, 27);
            btnTogglePassword.TabIndex = 25;
            btnTogglePassword.Text = "View";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAccount.Location = new Point(565, 379);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(102, 70);
            btnUpdateAccount.TabIndex = 26;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(823, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCancelAll
            // 
            btnCancelAll.BackColor = SystemColors.Info;
            btnCancelAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelAll.Location = new Point(193, 559);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(103, 60);
            btnCancelAll.TabIndex = 28;
            btnCancelAll.Text = "Cancel All";
            btnCancelAll.UseVisualStyleBackColor = false;
            btnCancelAll.Click += btnCancelAll_Click;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1105, 741);
            Controls.Add(btnCancelAll);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnTogglePassword);
            Controls.Add(btnSave);
            Controls.Add(txtReNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(dtDob);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProfile";
            Text = "AdminProfile";
            Load += AdminProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private DateTimePicker dtDob;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label9;
        private Label label10;
        private TextBox txtAccount;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Label label11;
        private Label label12;
        private TextBox txtNewPass;
        private TextBox txtReNewPass;
        private Button btnSave;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnTogglePassword;
        private Button btnUpdateAccount;
        private Button btnCancel;
        private Button btnCancelAll;
    }
}