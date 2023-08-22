namespace MilkTea
{
    partial class AdminBranch
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
            dgvAdminBranch = new DataGridView();
            label7 = new Label();
            lbBranchTotalOrder = new Label();
            lbBranchName = new Label();
            lbBranchPhone = new Label();
            lbBranchAddress = new Label();
            label18 = new Label();
            lbBranchRevenue = new Label();
            txtManager = new TextBox();
            txtBranchName = new TextBox();
            txtBranchPhone = new TextBox();
            txtBranchAddress = new TextBox();
            txtBranchTotalOrder = new TextBox();
            txtBranchRevenue = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            txtMyBranchName = new TextBox();
            txtMyBranchPhone = new TextBox();
            txtMyBranchAddress = new TextBox();
            btnUpdate = new Button();
            label17 = new Label();
            txtMyManagerName = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnFilterAddress = new Button();
            cbFilterAddress = new ComboBox();
            cbFilterPhone = new ComboBox();
            btnFilterPhone = new Button();
            btnAllBranches = new Button();
            btnFirstPage = new Button();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            btnLastPage = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAdminBranch).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(466, 22);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 0;
            label1.Text = "Branches";
            // 
            // dgvAdminBranch
            // 
            dgvAdminBranch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminBranch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminBranch.Location = new Point(55, 84);
            dgvAdminBranch.Name = "dgvAdminBranch";
            dgvAdminBranch.RowHeadersWidth = 51;
            dgvAdminBranch.RowTemplate.Height = 29;
            dgvAdminBranch.Size = new Size(1004, 317);
            dgvAdminBranch.TabIndex = 5;
            dgvAdminBranch.CellClick += dgvAdminBranch_CellClick;
            dgvAdminBranch.ColumnHeaderMouseClick += dgvAdminBranch_ColumnHeaderMouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 45);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 7;
            label7.Text = "Manager";
            // 
            // lbBranchTotalOrder
            // 
            lbBranchTotalOrder.AutoSize = true;
            lbBranchTotalOrder.Location = new Point(8, 186);
            lbBranchTotalOrder.Name = "lbBranchTotalOrder";
            lbBranchTotalOrder.Size = new Size(102, 20);
            lbBranchTotalOrder.TabIndex = 9;
            lbBranchTotalOrder.Text = "Total of Order";
            // 
            // lbBranchName
            // 
            lbBranchName.AutoSize = true;
            lbBranchName.Location = new Point(8, 80);
            lbBranchName.Name = "lbBranchName";
            lbBranchName.Size = new Size(98, 20);
            lbBranchName.TabIndex = 16;
            lbBranchName.Text = "Branch Name";
            // 
            // lbBranchPhone
            // 
            lbBranchPhone.AutoSize = true;
            lbBranchPhone.Location = new Point(8, 116);
            lbBranchPhone.Name = "lbBranchPhone";
            lbBranchPhone.Size = new Size(50, 20);
            lbBranchPhone.TabIndex = 17;
            lbBranchPhone.Text = "Phone";
            // 
            // lbBranchAddress
            // 
            lbBranchAddress.AccessibleDescription = "";
            lbBranchAddress.AutoSize = true;
            lbBranchAddress.Location = new Point(8, 155);
            lbBranchAddress.Name = "lbBranchAddress";
            lbBranchAddress.Size = new Size(62, 20);
            lbBranchAddress.TabIndex = 18;
            lbBranchAddress.Text = "Address";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(55, 61);
            label18.Name = "label18";
            label18.Size = new Size(96, 20);
            label18.TabIndex = 19;
            label18.Text = "All Branches";
            // 
            // lbBranchRevenue
            // 
            lbBranchRevenue.AutoSize = true;
            lbBranchRevenue.Location = new Point(8, 215);
            lbBranchRevenue.Name = "lbBranchRevenue";
            lbBranchRevenue.Size = new Size(65, 20);
            lbBranchRevenue.TabIndex = 20;
            lbBranchRevenue.Text = "Revenue";
            // 
            // txtManager
            // 
            txtManager.Location = new Point(175, 38);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(125, 27);
            txtManager.TabIndex = 21;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(175, 73);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(125, 27);
            txtBranchName.TabIndex = 22;
            // 
            // txtBranchPhone
            // 
            txtBranchPhone.Location = new Point(175, 109);
            txtBranchPhone.Name = "txtBranchPhone";
            txtBranchPhone.Size = new Size(125, 27);
            txtBranchPhone.TabIndex = 23;
            // 
            // txtBranchAddress
            // 
            txtBranchAddress.Location = new Point(175, 146);
            txtBranchAddress.Name = "txtBranchAddress";
            txtBranchAddress.Size = new Size(125, 27);
            txtBranchAddress.TabIndex = 24;
            // 
            // txtBranchTotalOrder
            // 
            txtBranchTotalOrder.Location = new Point(175, 179);
            txtBranchTotalOrder.Name = "txtBranchTotalOrder";
            txtBranchTotalOrder.Size = new Size(125, 27);
            txtBranchTotalOrder.TabIndex = 25;
            // 
            // txtBranchRevenue
            // 
            txtBranchRevenue.Location = new Point(175, 212);
            txtBranchRevenue.Name = "txtBranchRevenue";
            txtBranchRevenue.Size = new Size(125, 27);
            txtBranchRevenue.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 28;
            label2.Text = "Branch Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 495);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 54);
            label16.Name = "label16";
            label16.Size = new Size(98, 20);
            label16.TabIndex = 30;
            label16.Text = "Branch Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 88);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 32;
            label19.Text = "Phone";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 125);
            label20.Name = "label20";
            label20.Size = new Size(62, 20);
            label20.TabIndex = 33;
            label20.Text = "Address";
            // 
            // txtMyBranchName
            // 
            txtMyBranchName.Location = new Point(132, 54);
            txtMyBranchName.Name = "txtMyBranchName";
            txtMyBranchName.Size = new Size(125, 27);
            txtMyBranchName.TabIndex = 34;
            // 
            // txtMyBranchPhone
            // 
            txtMyBranchPhone.Location = new Point(132, 88);
            txtMyBranchPhone.Name = "txtMyBranchPhone";
            txtMyBranchPhone.Size = new Size(125, 27);
            txtMyBranchPhone.TabIndex = 36;
            // 
            // txtMyBranchAddress
            // 
            txtMyBranchAddress.Location = new Point(132, 125);
            txtMyBranchAddress.Name = "txtMyBranchAddress";
            txtMyBranchAddress.Size = new Size(125, 27);
            txtMyBranchAddress.TabIndex = 37;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(0, 212);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 165);
            label17.Name = "label17";
            label17.Size = new Size(117, 20);
            label17.TabIndex = 39;
            label17.Text = "Branch Manager";
            // 
            // txtMyManagerName
            // 
            txtMyManagerName.Location = new Point(132, 165);
            txtMyManagerName.Name = "txtMyManagerName";
            txtMyManagerName.Size = new Size(125, 27);
            txtMyManagerName.TabIndex = 40;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(14, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(132, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 42;
            // 
            // btnFilterAddress
            // 
            btnFilterAddress.Location = new Point(14, 132);
            btnFilterAddress.Name = "btnFilterAddress";
            btnFilterAddress.Size = new Size(94, 57);
            btnFilterAddress.TabIndex = 43;
            btnFilterAddress.Text = "Filter theo Address";
            btnFilterAddress.UseVisualStyleBackColor = true;
            btnFilterAddress.Click += btnFilterAddress_Click;
            // 
            // cbFilterAddress
            // 
            cbFilterAddress.FormattingEnabled = true;
            cbFilterAddress.Items.AddRange(new object[] { "Hai Duong", "Ha Noi" });
            cbFilterAddress.Location = new Point(132, 145);
            cbFilterAddress.Name = "cbFilterAddress";
            cbFilterAddress.Size = new Size(151, 28);
            cbFilterAddress.TabIndex = 44;
            // 
            // cbFilterPhone
            // 
            cbFilterPhone.FormattingEnabled = true;
            cbFilterPhone.Items.AddRange(new object[] { "0123456789", "0987654321" });
            cbFilterPhone.Location = new Point(132, 229);
            cbFilterPhone.Name = "cbFilterPhone";
            cbFilterPhone.Size = new Size(151, 28);
            cbFilterPhone.TabIndex = 45;
            // 
            // btnFilterPhone
            // 
            btnFilterPhone.Location = new Point(14, 212);
            btnFilterPhone.Name = "btnFilterPhone";
            btnFilterPhone.Size = new Size(94, 61);
            btnFilterPhone.TabIndex = 46;
            btnFilterPhone.Text = "Filter Phone";
            btnFilterPhone.UseVisualStyleBackColor = true;
            btnFilterPhone.Click += btnFilterPhone_Click;
            // 
            // btnAllBranches
            // 
            btnAllBranches.Location = new Point(14, 15);
            btnAllBranches.Name = "btnAllBranches";
            btnAllBranches.Size = new Size(94, 50);
            btnAllBranches.TabIndex = 47;
            btnAllBranches.Text = "All Branches";
            btnAllBranches.UseVisualStyleBackColor = true;
            btnAllBranches.Click += btnAllBranches_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(3, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(94, 29);
            btnFirstPage.TabIndex = 48;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(130, 3);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 49;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(254, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 50;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.Location = new Point(378, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(94, 29);
            btnLastPage.TabIndex = 51;
            btnLastPage.Text = "Last Page";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lbBranchName);
            panel1.Controls.Add(lbBranchPhone);
            panel1.Controls.Add(lbBranchAddress);
            panel1.Controls.Add(lbBranchTotalOrder);
            panel1.Controls.Add(lbBranchRevenue);
            panel1.Controls.Add(txtManager);
            panel1.Controls.Add(txtBranchName);
            panel1.Controls.Add(txtBranchPhone);
            panel1.Controls.Add(txtBranchAddress);
            panel1.Controls.Add(txtBranchTotalOrder);
            panel1.Controls.Add(txtBranchRevenue);
            panel1.Location = new Point(390, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 252);
            panel1.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 27;
            label3.Text = "Branch Detail";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAllBranches);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnFilterAddress);
            panel2.Controls.Add(btnFilterPhone);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(cbFilterAddress);
            panel2.Controls.Add(cbFilterPhone);
            panel2.Location = new Point(729, 447);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 282);
            panel2.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(txtMyBranchName);
            panel3.Controls.Add(txtMyBranchPhone);
            panel3.Controls.Add(txtMyManagerName);
            panel3.Controls.Add(txtMyBranchAddress);
            panel3.Location = new Point(61, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 252);
            panel3.TabIndex = 54;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFirstPage);
            panel4.Controls.Add(btnPreviousPage);
            panel4.Controls.Add(btnNextPage);
            panel4.Controls.Add(btnLastPage);
            panel4.Location = new Point(325, 407);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 34);
            panel4.TabIndex = 55;
            // 
            // AdminBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1141, 738);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label18);
            Controls.Add(dgvAdminBranch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBranch";
            Text = "AdminBranch";
            Load += AdminBranch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdminBranch).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAdminBranch;
        private Label label7;
        private Label lbBranchTotalOrder;
        private Label label11;
        private Label label14;
        private Label lbBranchName;
        private Label lbBranchPhone;
        private Label lbBranchAddress;
        private Label label18;
        private Label lbBranchRevenue;
        private TextBox txtManager;
        private TextBox txtBranchName;
        private TextBox txtBranchPhone;
        private TextBox txtBranchAddress;
        private TextBox txtBranchTotalOrder;
        private TextBox txtBranchRevenue;
        private Label label2;
        private Label label9;
        private Label label16;
        private Label label19;
        private Label label20;
        private TextBox txtMyBranchName;
        private TextBox txtMyBranchPhone;
        private TextBox txtMyBranchAddress;
        private Button btnUpdate;
        private Label label17;
        private TextBox txtMyManagerName;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btn;
        private Button btnFilterAddress;
        private ComboBox cbFilterAddress;
        private ComboBox cbFilterPhone;
        private Button btnFilterPhone;
        private Button btnAllBranches;
        private Button btnFirstPage;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Button btnLastPage;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
    }
}