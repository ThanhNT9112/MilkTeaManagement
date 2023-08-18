using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea
{
	public partial class AdminMenu : Form
	{
		public AdminMenu()
		{
			InitializeComponent();

		}

		public AdminMenu(Account account)
		{
			InitializeComponent();
			lbWelcome.Text = "Wellcome " + account.Username + " !";

		}

		private void lbWelcome_Click(object sender, EventArgs e)
		{

		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
	}
}
