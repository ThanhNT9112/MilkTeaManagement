using DemoDataAccess;
using System;
using System.Collections.Generic;
using MilkTea.Models;
using System.Linq;
using System.Windows.Forms;

namespace ShoppingCartNew
{
    public partial class ShoppingCart : Form
    {
        private readonly MilkteaDBContext db = new MilkteaDBContext();


        public ShoppingCart()
        {
            InitializeComponent();
        }

        List<UserControl1> ProductControls = new List<UserControl1>();

        private decimal CalculateFreight()
        {
            decimal sum = 0;
            foreach (UserControl1 uc in ProductControls)
                sum += uc.ProductPrice * uc.Quantity;
            return sum;
        }

        private void Product_DataChange(object sender, EventArgs e)
        {
            label2.Text = CalculateFreight().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Print the bill
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCategory.SelectedItem == null)
            {
                return;
            }
            else
            {
                int categoryId = Convert.ToInt32(comboCategory.SelectedValue);
                List<Product> products = db.Products.Where(p => p.CategoryId == categoryId).ToList();
                dataGridView1.DataSource = products;
                this.dataGridView1.Columns["ProductId"].Visible = false;
                this.dataGridView1.Columns["CategoryId"].Visible = false;
            }
        }

        private void reloadEmployee()
        {
            comboCategory.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Product product = db.Products.Find(Convert.ToInt32(row.Cells[1].Value));
                    UserControl1 MyControl = new UserControl1(product.ProductId.ToString(), product.ProductName, Convert.ToDecimal(product.Price), 1);
                    MyControl.PropertyChange += Product_DataChange;
                    if (!ProductControls.Contains(MyControl))
                    {
                        ProductControls.Add(MyControl);
                        flowLayoutPanel1.Controls.Add(MyControl);
                    }
                    else
                    {
                        ProductControls[ProductControls.IndexOf(MyControl)].Quantity += 1;
                    }
                }
            }
            Product_DataChange(null, null);
        }

        private void NormalImage(object sender, EventArgs e)
        {
            foreach (DataGridViewImageColumn column in dataGridView1.Columns)
            {
                column.ImageLayout = DataGridViewImageCellLayout.Normal;
                column.Description = "Normal";
            }
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
            cbColumn.HeaderText = "Check";
            cbColumn.Name = "cbColumn";
            dataGridView1.Columns.Add(cbColumn);

            comboCategory.DataSource = db.Categories.ToList();
            comboCategory.SelectedItem = null;
            comboCategory.SelectedText = "--select--";

            List<Product> products = db.Products.ToList();
            dataGridView1.DataSource = products;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Image2";
            img.Name = "img";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string zz = dataGridView1.Rows[i].Cells[5].Value.ToString();
                Image image2 = Image.FromFile(@zz);
                img.Image = image2;
            }
            dataGridView1.Columns.Add(img);

            this.dataGridView1.Columns["ProductId"].Visible = false;
            this.dataGridView1.Columns["CategoryId"].Visible = false;

            flowLayoutPanel1.AutoScroll = true;
        }

        
    }
}