using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

		// Revenue - Kienbv
		private void btnRevenue_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			AdminRevenue adminRevenue = new AdminRevenue();
			adminRevenue.TopLevel = false;
			mainPanel.Controls.Add(adminRevenue);
			adminRevenue.Show();
		}

		// Branch - Kienbv
		private void btnBranch_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			AdminBranch adminBranch = new AdminBranch();
			adminBranch.TopLevel = false;
			mainPanel.Controls.Add(adminBranch);
			adminBranch.Show();
		}

		// Profile - Kienbv
		private void btnProfile_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			AdminProfile adminProfile = new AdminProfile();
			adminProfile.TopLevel = false;
			mainPanel.Controls.Add(adminProfile);
			adminProfile.Show();
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			AdminProduct adminProduct = new AdminProduct();
			adminProduct.TopLevel = false;
			mainPanel.Controls.Add(adminProduct);
			adminProduct.Show();
		}
	}
}
