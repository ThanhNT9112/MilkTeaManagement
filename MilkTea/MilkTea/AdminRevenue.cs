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
    public partial class AdminRevenue : Form
    {
        public AdminRevenue()
        {
            InitializeComponent();
        }

        private void AdminRevenue_Load(object sender, EventArgs e)
        {
            dgvAminRevenueOrder.ColumnHeaderMouseClick += dgvAminRevenueOrder_ColumnHeaderMouseClick;
            txtTotalOfOrders.ReadOnly = true;
            txtBranchRevenue.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtBranchName.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;
            TotalOfOrdersAndRevenue();
            LoadOrder();
        }

        private void LoadOrder()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrder.AutoGenerateColumns = false;
                dgvAminRevenueOrder.Columns.Clear();
                dgvAminRevenueOrder.DataSource = null;

                var adminRevenueOrderList = db.Orders
                    .Where(odlist => odlist.BranchId == db.Accounts
                        .Where(a => a.AccountId == 2) // chưa lấy được account id theo login -> vde duy nhất 
                        .Select(a => a.BranchId)
                        .FirstOrDefault())
                    .Select(odlist => new
                    {
                        OrderId = odlist.OrderId,
                        Total = odlist.Total,
                        DateCreated = odlist.DateCreated,

                        BranchName = db.Branches
                            .Where(b => b.BranchId == odlist.BranchId)
                            .Select(b => b.BranchName)
                            .FirstOrDefault(),

                        TottalOrder = db.Orders.Sum(o => o.Total),
                        TotalPriceSum = db.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice)
                    })
                    .ToList();

                dgvAminRevenueOrder.DataSource = adminRevenueOrderList;

                // tổ chức các cột cho datagrid view theo yêu cầu bài toán 
                DataGridViewTextBoxColumn total = new DataGridViewTextBoxColumn();
                total.Name = "Total";
                total.HeaderText = "Total";
                total.DataPropertyName = "Total";

                DataGridViewTextBoxColumn dateCreated = new DataGridViewTextBoxColumn();
                dateCreated.Name = "DateCreated";
                dateCreated.HeaderText = "DateCreated";
                dateCreated.DataPropertyName = "DateCreated";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn orderId = new DataGridViewTextBoxColumn();
                orderId.Name = "OrderId";
                orderId.HeaderText = "Order Id";
                orderId.DataPropertyName = "OrderId";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAminRevenueOrder.Columns.Add(total);
                dgvAminRevenueOrder.Columns.Add(dateCreated);
                dgvAminRevenueOrder.Columns.Add(branchName);
                dgvAminRevenueOrder.Columns.Add(orderId);
                dgvAminRevenueOrder.Columns["OrderId"].Visible = false;

            }
        }

        private void dgvAminRevenueOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrder.Rows.Count && e.ColumnIndex >= 0)
            {
                var total = dgvAminRevenueOrder.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                var dateCreated = dgvAminRevenueOrder.Rows[e.RowIndex].Cells["DateCreated"].Value.ToString();
                var branchName = dgvAminRevenueOrder.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();

                // binding du lieu 
                txtTotal.Text = total;
                dtDateCreated.Value = DateTime.Parse(dateCreated); // Parse string to DateTime
                txtBranchName.Text = branchName;
            }

            // hiển thị lên dgvAminRevenueOrderDetail
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrder.Rows.Count && e.ColumnIndex >= 0)
            {
                var orderId = Convert.ToInt32(dgvAminRevenueOrder.Rows[e.RowIndex].Cells["OrderId"].Value);
                DisplayOrderDetails(orderId);
            }
        }

        // display thông tin lên dgvOrrderDetail
        private void DisplayOrderDetails(int orderId)
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrderDetail.AutoGenerateColumns = false;
                dgvAminRevenueOrderDetail.Columns.Clear();
                dgvAminRevenueOrderDetail.DataSource = null;

                // total quantities of 1 orderdetail
                var totalOFQuantities = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Quantity);
                // total of prices of 1 orderdetail
                var totalOFPrices = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.TotalPrice);

                var orderDetails = db.OrderDetails
                    .Where(od => od.OrderId == orderId)
                    .Select(od => new
                    {
                        ProductId = od.ProductId,
                        Quantity = od.Quantity,
                        TotalOfQuantities = totalOFQuantities,
                        TotalPrice = od.TotalPrice,
                        TotalOfPrices = totalOFPrices,
                        ProductName = db.Products
                            .Where(p => p.ProductId == od.ProductId)
                            .Select(p => p.ProductName)
                            .FirstOrDefault()
                    })
                    .ToList();

                dgvAminRevenueOrderDetail.DataSource = orderDetails;

                // Tạo các cột cho DataGridView dgvAminRevenueOrderDetail
                DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                productNameColumn.Name = "ProductName";
                productNameColumn.HeaderText = "Product Name";
                productNameColumn.DataPropertyName = "ProductName";

                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.Name = "Quantity";
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.DataPropertyName = "Quantity";

                DataGridViewTextBoxColumn totalOfQuantities = new DataGridViewTextBoxColumn();
                totalOfQuantities.Name = "TotalOfQuantities";
                totalOfQuantities.HeaderText = "Total Of Quantities";
                totalOfQuantities.DataPropertyName = "TotalOfQuantities";

                DataGridViewTextBoxColumn totalPrice = new DataGridViewTextBoxColumn();
                totalPrice.Name = "TotalPrice";
                totalPrice.HeaderText = "Total Price";
                totalPrice.DataPropertyName = "TotalPrice";

                DataGridViewTextBoxColumn totalOfPrices = new DataGridViewTextBoxColumn();
                totalOfPrices.Name = "TotalOfPrices";
                totalOfPrices.HeaderText = "Total Of Prices";
                totalOfPrices.DataPropertyName = "TotalOfPrices";

                // Thêm các cột vào DataGridView dgvAminRevenueOrderDetail
                dgvAminRevenueOrderDetail.Columns.Add(productNameColumn);
                dgvAminRevenueOrderDetail.Columns.Add(quantityColumn);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfQuantities);
                dgvAminRevenueOrderDetail.Columns.Add(totalPrice);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfPrices);
                dgvAminRevenueOrderDetail.Columns["TotalOfQuantities"].Visible = false;
                dgvAminRevenueOrderDetail.Columns["TotalOfPrices"].Visible = false;
            }
        }

        private void dgvAminRevenueOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrderDetail.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAminRevenueOrderDetail.Rows[e.RowIndex];

                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                var quantity = selectedRow.Cells["Quantity"].Value.ToString();
                var totalPrice = selectedRow.Cells["TotalPrice"].Value.ToString();
                var totalOfQuantities = selectedRow.Cells["TotalOfQuantities"].Value.ToString();
                var totalOfPrices = selectedRow.Cells["TotalOfPrices"].Value.ToString();

                // Gán thông tin vào các TextBox tương ứng
                txtProductName.Text = productName;
                txtQuantity.Text = quantity;
                txttotalQuantities.Text = totalOfQuantities;
                txtTotalPrice.Text = totalPrice;
                txtTotalPrices.Text = totalOfPrices;
            }
        }

        // Total of Orders
        private void TotalOfOrdersAndRevenue()
        {
            using (var db = new MilkteaDBContext())
            {
                var accountId = 2;

                var totalOfOrders = db.Orders
                    .Where(o => o.BranchId == db.Accounts
                        .Where(a => a.AccountId == accountId)
                        .Select(a => a.BranchId)
                        .FirstOrDefault())
                    .Sum(o => o.Total);

                txtTotalOfOrders.Text = totalOfOrders.ToString();

                var revenue = db.OrderDetails
                    .Where(od => od.Order.BranchId == db.Branches
                        .Where(b => b.BranchId == db.Accounts
                            .Where(a => a.AccountId == accountId)
                            .Select(a => a.BranchId)
                            .FirstOrDefault())
                        .Select(b => b.BranchId)
                        .FirstOrDefault())
                    .Sum(od => od.TotalPrice);

                txtBranchRevenue.Text = revenue.ToString();
            }
        }

        // search - defect 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Must not be Empty.");
                return;
            }

            if (dgvAminRevenueOrder.SelectedRows.Count > 0)
            {
                var orderId = Convert.ToInt32(dgvAminRevenueOrder.SelectedRows[0].Cells["OrderId"].Value);
                LoadSearch(orderId, txtSearch.Text.Trim());
            }
        }

        private void LoadSearch(int orderId, string searchKeyword)
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrderDetail.AutoGenerateColumns = false;
                dgvAminRevenueOrderDetail.Columns.Clear();
                dgvAminRevenueOrderDetail.DataSource = null;

                var totalOFQuantities = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Quantity);
                var totalOFPrices = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.TotalPrice);

                var orderDetails = db.OrderDetails
                    .Where(od => od.OrderId == orderId && od.Product.ProductName.Contains(searchKeyword))
                    .Select(od => new
                    {
                        ProductId = od.ProductId,
                        Quantity = od.Quantity,
                        TotalOfQuantities = totalOFQuantities,
                        TotalPrice = od.TotalPrice,
                        TotalOfPrices = totalOFPrices,
                        ProductName = od.Product.ProductName
                    })
                    .ToList();

                dgvAminRevenueOrderDetail.DataSource = orderDetails;

                DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                productNameColumn.Name = "ProductName";
                productNameColumn.HeaderText = "Product Name";
                productNameColumn.DataPropertyName = "ProductName";

                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.Name = "Quantity";
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.DataPropertyName = "Quantity";

                DataGridViewTextBoxColumn totalOfQuantities = new DataGridViewTextBoxColumn();
                totalOfQuantities.Name = "TotalOfQuantities";
                totalOfQuantities.HeaderText = "Total Of Quantities";
                totalOfQuantities.DataPropertyName = "TotalOfQuantities";

                DataGridViewTextBoxColumn totalPrice = new DataGridViewTextBoxColumn();
                totalPrice.Name = "TotalPrice";
                totalPrice.HeaderText = "Total Price";
                totalPrice.DataPropertyName = "TotalPrice";

                DataGridViewTextBoxColumn totalOfPrices = new DataGridViewTextBoxColumn();
                totalOfPrices.Name = "TotalOfPrices";
                totalOfPrices.HeaderText = "Total Of Prices";
                totalOfPrices.DataPropertyName = "TotalOfPrices";

                dgvAminRevenueOrderDetail.Columns.Add(productNameColumn);
                dgvAminRevenueOrderDetail.Columns.Add(quantityColumn);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfQuantities);
                dgvAminRevenueOrderDetail.Columns.Add(totalPrice);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfPrices);
                dgvAminRevenueOrderDetail.Columns["TotalOfQuantities"].Visible = false;
                dgvAminRevenueOrderDetail.Columns["TotalOfPrices"].Visible = false;

                // Hide non-matching rows
                foreach (DataGridViewRow row in dgvAminRevenueOrderDetail.Rows)
                {
                    var productName = row.Cells["ProductName"].Value.ToString();
                    if (!productName.Contains(searchKeyword))
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        // sort click title cho order -> defect 
        private void dgvAminRevenueOrder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvAminRevenueOrder.Columns[e.ColumnIndex];

            // Kiểm tra xem có đúp chuột hay không
            if (doubleClick)
            {
                // Đảo ngược hướng sắp xếp khi đúp chuột
                currentSortDirection = (currentSortDirection == ListSortDirection.Ascending)
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
            else
            {
                SortData(clickedColumn);
            }

            // Đặt biến doubleClick thành true để đánh dấu lần nhấp chuột
            doubleClick = true;

            // Đợi 300ms để kiểm tra xem có phải đúp chuột hay không
            Task.Delay(3000);

            // Đặt biến doubleClick thành false sau khi đợi
            doubleClick = false;
        }

        // khai báo 1 biến hiện tại order
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        private bool doubleClick = false;
        private void SortData(DataGridViewColumn column)
        {
            string propertyName = column.DataPropertyName;

            using (var db = new MilkteaDBContext())
            {
                List<Branch> branchToDisplay = db.Branches.ToList(); // Branch Name

                List<Order> orderToDisplay = db.Orders.ToList(); // thonng tin cac Order

                if (currentSortDirection == ListSortDirection.Ascending)
                {
                    orderToDisplay = orderToDisplay.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    orderToDisplay = orderToDisplay.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
                dgvAminRevenueOrder.DataSource = orderToDisplay;
            }
        }

        // trích xuất giá trị của một thuộc tính cụ thể từ một đối tượng bằng cách sử dụng reflection
        // reflection: tạo đối tượng, gọi phương thức
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        private void dgvAminRevenueOrderDetail_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        // khai báo 1 biến hiện tại cho orderdetail 
        private ListSortDirection currentSortDirectionOD = ListSortDirection.Ascending;
        private bool doubleClickOD = false;
        private void SortDataOD(DataGridViewColumn column)
        {

        }

        // filter by date 
        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var fromDate = dtFrom.Value.Date;
                var toDate = dtTo.Value.Date.AddDays(1).AddTicks(-1); // Include the entire selected day

                var filteredOrders = db.Orders
                    .Where(o => o.DateCreated >= fromDate && o.DateCreated <= toDate)
                    .ToList();

                dgvAminRevenueOrder.DataSource = filteredOrders;
            }
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        // paging 
        private int currentPage = 1;
        private int itemsPerPage = 1; // số lượng mỗi trang

        private void LoadOrder(int page)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalOrders = db.Branches.Count();
                var totalPages = (int)Math.Ceiling((double)totalOrders / itemsPerPage);

                if (page < 1)
                    page = 1;
                if (page > totalPages)
                    page = totalPages;

                currentPage = page;

                var ordersToDisplay = db.Orders
                    .OrderBy(b => b.OrderId)
                    .Skip((currentPage - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();

                dgvAminRevenueOrder.DataSource = ordersToDisplay;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadOrder(1);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            LoadOrder(currentPage - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadOrder(currentPage + 1);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalOrder = db.Orders.Count();
                var totalPages = (int)Math.Ceiling((double)totalOrder / itemsPerPage);

                LoadOrder(totalPages);
            }
        }
    }
}
// cách 2 để show
//dgvAminRevenueOrderDetail.Columns.AddRange(
//                    productNameColumn, quantityColumn, totalOfQuantitiesColumn,
//                    totalPriceColumn, totalOfPricesColumn
//                );