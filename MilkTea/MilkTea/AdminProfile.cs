using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MilkTea.Models;

namespace MilkTea
{
    public partial class AdminProfile : Form
    {
        private int loggedInManagerId;
        public AdminProfile()
        {
            InitializeComponent();
        }


        // still not get the account id yet***
        //private int loggedInManagerId;
        //public AdminProfile(int loggedInManagerId)
        //{
        //    InitializeComponent();
        //    this.loggedInManagerId = loggedInManagerId;
        //}

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;
            AccountLoad();
            ManagerLoad();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            AccountLoad();
            ManagerLoad();
            txtNewPass.Clear();
            txtReNewPass.Clear();
        }

        private void ManagerLoad()
        {
            using (var db = new MilkteaDBContext())
            {
                var manager = db.Managers.FirstOrDefault(m => m.ManagerId == 2); //loggedInManagerId

                if (manager != null)
                {
                    txtName.Text = manager.Name;
                    rbMale.Checked = manager.Gender == true;
                    rbFemale.Checked = manager.Gender == false;
                    dtDob.Value = manager.Dob ?? DateTime.MinValue; // Handle null value
                    txtPhone.Text = manager.Phone;
                    txtEmail.Text = manager.Email;
                    txtAddress.Text = manager.Address;
                }
            }
        }

        private void AccountLoad()
        {
            using (var db = new MilkteaDBContext())
            {
                var account = db.Accounts.FirstOrDefault(a => a.AccountId == 2);
                if (account != null)
                {
                    txtAccount.Text = account.Username;
                    txtPassword.Text = account.Password;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                // Lấy dữ liệu trên input form
                var managerName = txtName.Text;
                var manageGender = rbMale.Checked;
                var managerDob = dtDob.Value;
                var managerPhone = txtPhone.Text;
                var managerEmail = txtEmail.Text;
                var managerAddress = txtAddress.Text;

                // thực hiện update 
                var manager = db.Managers.SingleOrDefault(m => m.ManagerId == 2);
                if (manager != null)
                {
                    // update 
                    manager.Name = managerName;
                    manager.Gender = manageGender;
                    manager.Dob = managerDob;
                    manager.Phone = managerPhone;
                    manager.Email = managerEmail;
                    manager.Address = managerAddress;

                    // save changes 
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Update Manager success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // xem password ẩn
        private bool isPasswordVisible = true;
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = true; // Show plain text
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false; // Hide password
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                // Lấy dữ liệu trên input form
                var accountName = txtAccount.Text;

                // thực hiện update 
                var account = db.Accounts.SingleOrDefault(m => m.AccountId == 2);
                if (account != null)
                {
                    // update 
                    account.Username = accountName;

                    // save changes 
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Update Account success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool IsValid()
        {
            bool flag = true;
            string msg = "";

            if (txtNewPass.Text.Equals("") || txtReNewPass.Text.Equals(""))
            {
                flag = false;
                msg += "Must not be empty.\n";
            }
            else if (txtNewPass.Text != txtReNewPass.Text)
            {
                flag = false;
                msg += "Must be equal.\n";
            }
            else
            {
                return flag;
            }

            if (flag == false)
            {
                MessageBox.Show(msg);
            }
            return flag;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (var db = new MilkteaDBContext())
                {
                    // Lấy dữ liệu trên input form
                    var newPass = txtNewPass.Text;
                    var reNewPass = txtReNewPass.Text;

                    // thực hiện update
                    var account = db.Accounts.SingleOrDefault(a => a.AccountId == 2);
                    if (account != null)
                    {
                        // update
                        account.Password = newPass;

                        // save changes
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Update Password success");
                            txtNewPass.Clear();
                            txtReNewPass.Clear();
                            AccountLoad();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNewPass.Clear();
            txtReNewPass.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}