using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private Account accountt = new Account();
        public EmployeeMenu(Account account)
        {
            InitializeComponent();
            accountt = account;
            //txtUsername.Text = "Welcome " + account.userName + " !";
            //timer1.Start();
        }
    }
}
