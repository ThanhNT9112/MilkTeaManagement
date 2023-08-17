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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            
        }

        public AdminMenu(Account account)
        {
            InitializeComponent();
            //txtWellcome.Text = "Wellcome " + account.userName + " !";
            
        }
    }
}
