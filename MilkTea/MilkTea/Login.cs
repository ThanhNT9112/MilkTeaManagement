using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MilkTea.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilkTea
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Account accountList = new Account();
        Role roleList = new Role();
        public bool validAccount()
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                return false;
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.]+)$");
            if (!regex.IsMatch(user) || !regex.IsMatch(pass))
            {
                return false;
			}
			return true;
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
			string user = txtUsername.Text;
			string pass = txtPassword.Text;
			using (var context = new MilkteaDBContext())
			{
				Account ac = context.Accounts.Where(x => x.Username == user && x.Password == pass).FirstOrDefault();
				if (ac == null)
				{
					MessageBox.Show("Dang nhap that bai");
				}
				else
				{
					
						if (ac.RoleId == 1)
						{
							AdminMenu form = new AdminMenu();
							form.Show();
							this.Hide();
						}
						else
						{
							EmployeeMenu form = new EmployeeMenu();
							form.Show();
							this.Hide();
						}
				
				}

			}
		}
    }
}