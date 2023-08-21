namespace MilkTea
{
    partial class AdminProduct
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
            dgvAdProduct = new DataGridView();
            groupBox1 = new GroupBox();
            nudQuantity = new NumericUpDown();
            btnUpdate = new Button();
            btnAdd = new Button();
            pbImage = new PictureBox();
            btnBrowse = new Button();
            txtImage = new TextBox();
            txtOrigin = new TextBox();
            txtPrice = new TextBox();
            cbCategory = new ComboBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            cbFilter = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // dgvAdProduct
            // 
            dgvAdProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdProduct.Location = new Point(1, 88);
            dgvAdProduct.Name = "dgvAdProduct";
            dgvAdProduct.RowHeadersWidth = 51;
            dgvAdProduct.RowTemplate.Height = 29;
            dgvAdProduct.Size = new Size(760, 663);
            dgvAdProduct.TabIndex = 0;
            dgvAdProduct.CellClick += dgvAdProduct_CellClick;
            dgvAdProduct.CellContentClick += dgvAdProduct_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(pbImage);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(txtImage);
            groupBox1.Controls.Add(txtOrigin);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(767, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 674);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(120, 213);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(167, 27);
            nudQuantity.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(406, 595);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(406, 466);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(9, 429);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(357, 239);
            pbImage.TabIndex = 15;
            pbImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(435, 375);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(74, 27);
            btnBrowse.TabIndex = 14;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(120, 375);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(298, 27);
            txtImage.TabIndex = 13;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(120, 323);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(167, 27);
            txtOrigin.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 267);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 27);
            txtPrice.TabIndex = 11;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(120, 152);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(167, 28);
            cbCategory.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 27);
            txtName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(167, 27);
            txtId.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 382);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 6;
            label7.Text = "Image";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 330);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Origin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 274);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 220);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 160);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 99);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(776, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save To Excel";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.Simple;
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(96, 43);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 28);
            cbFilter.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 51);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 4;
            label8.Text = "Filter";
            // 
            // AdminProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 971);
            Controls.Add(label8);
            Controls.Add(cbFilter);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(dgvAdProduct);
            Name = "AdminProduct";
            Text = "AdminProduct";
            Load += AdminProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdProduct;
        private GroupBox groupBox1;
        private NumericUpDown nudQuantity;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pbImage;
        private Button btnBrowse;
        private TextBox txtImage;
        private TextBox txtOrigin;
        private TextBox txtPrice;
        private ComboBox cbCategory;
        private TextBox txtName;
        private TextBox txtId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private ComboBox cbFilter;
        private Label label8;
    }
}