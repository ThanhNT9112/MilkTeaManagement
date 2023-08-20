using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MilkTea.Models;

namespace MilkTeaManagement
{
    public partial class AdminHome : Form
    {

        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            using (var context = new MilkteaDBContext())
            {
                var totalOrder = context.Orders.Count();
                label4.Text = totalOrder.ToString();

                var totalProduct = context.Products.Count();
                label5.Text = totalProduct.ToString();

            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
