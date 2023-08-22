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
			pbImage = new PictureBox();
			btnUpdate = new Button();
			btnSave = new Button();
			btnBrowse = new Button();
			txtImage = new TextBox();
			btnAdd = new Button();
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
			cbFilter = new ComboBox();
			label8 = new Label();
			btnFilter = new Button();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)dgvAdProduct).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvAdProduct
			// 
			dgvAdProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvAdProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAdProduct.Location = new Point(11, 65);
			dgvAdProduct.Name = "dgvAdProduct";
			dgvAdProduct.RowHeadersWidth = 51;
			dgvAdProduct.RowTemplate.Height = 29;
			dgvAdProduct.Size = new Size(626, 564);
			dgvAdProduct.TabIndex = 0;
			dgvAdProduct.CellClick += dgvAdProduct_CellClick;
			dgvAdProduct.CellContentClick += dgvAdProduct_CellContentClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(nudQuantity);
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
			groupBox1.Controls.Add(panel1);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(643, 65);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(466, 564);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			// 
			// nudQuantity
			// 
			nudQuantity.Location = new Point(118, 180);
			nudQuantity.Name = "nudQuantity";
			nudQuantity.Size = new Size(167, 27);
			nudQuantity.TabIndex = 18;
			// 
			// pbImage
			// 
			pbImage.Location = new Point(8, 365);
			pbImage.Name = "pbImage";
			pbImage.Size = new Size(329, 193);
			pbImage.TabIndex = 15;
			pbImage.TabStop = false;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(18, 66);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(82, 32);
			btnUpdate.TabIndex = 17;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(18, 127);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(82, 53);
			btnSave.TabIndex = 2;
			btnSave.Text = "Save To Excel";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnBrowse
			// 
			btnBrowse.Location = new Point(381, 319);
			btnBrowse.Name = "btnBrowse";
			btnBrowse.Size = new Size(79, 27);
			btnBrowse.TabIndex = 14;
			btnBrowse.Text = "Browse";
			btnBrowse.UseVisualStyleBackColor = true;
			btnBrowse.Click += btnBrowse_Click;
			// 
			// txtImage
			// 
			txtImage.Location = new Point(118, 318);
			txtImage.Name = "txtImage";
			txtImage.Size = new Size(257, 27);
			txtImage.TabIndex = 13;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(18, 13);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(82, 25);
			btnAdd.TabIndex = 16;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtOrigin
			// 
			txtOrigin.Location = new Point(118, 273);
			txtOrigin.Name = "txtOrigin";
			txtOrigin.Size = new Size(147, 27);
			txtOrigin.TabIndex = 12;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(118, 226);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(147, 27);
			txtPrice.TabIndex = 11;
			// 
			// cbCategory
			// 
			cbCategory.FormattingEnabled = true;
			cbCategory.Location = new Point(118, 128);
			cbCategory.Name = "cbCategory";
			cbCategory.Size = new Size(147, 28);
			cbCategory.TabIndex = 9;
			// 
			// txtName
			// 
			txtName.Location = new Point(118, 77);
			txtName.Name = "txtName";
			txtName.Size = new Size(261, 27);
			txtName.TabIndex = 8;
			// 
			// txtId
			// 
			txtId.Location = new Point(118, 28);
			txtId.Name = "txtId";
			txtId.Size = new Size(147, 27);
			txtId.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 325);
			label7.Name = "label7";
			label7.Size = new Size(51, 20);
			label7.TabIndex = 6;
			label7.Text = "Image";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 280);
			label6.Name = "label6";
			label6.Size = new Size(50, 20);
			label6.TabIndex = 5;
			label6.Text = "Origin";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 233);
			label5.Name = "label5";
			label5.Size = new Size(41, 20);
			label5.TabIndex = 4;
			label5.Text = "Price";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 187);
			label4.Name = "label4";
			label4.Size = new Size(65, 20);
			label4.TabIndex = 3;
			label4.Text = "Quantity";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(8, 136);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 2;
			label3.Text = "Category";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(8, 84);
			label2.Name = "label2";
			label2.Size = new Size(104, 20);
			label2.TabIndex = 1;
			label2.Text = "Product Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(8, 35);
			label1.Name = "label1";
			label1.Size = new Size(79, 20);
			label1.TabIndex = 0;
			label1.Text = "Product ID";
			// 
			// cbFilter
			// 
			cbFilter.FormattingEnabled = true;
			cbFilter.Location = new Point(116, 27);
			cbFilter.Name = "cbFilter";
			cbFilter.Size = new Size(133, 25);
			cbFilter.TabIndex = 3;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(11, 33);
			label8.Name = "label8";
			label8.Size = new Size(99, 19);
			label8.TabIndex = 4;
			label8.Text = "Categoty Filter";
			// 
			// btnFilter
			// 
			btnFilter.Location = new Point(266, 24);
			btnFilter.Name = "btnFilter";
			btnFilter.Size = new Size(65, 29);
			btnFilter.TabIndex = 18;
			btnFilter.Text = "Enter";
			btnFilter.UseVisualStyleBackColor = true;
			btnFilter.Click += btnFilter_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnAdd);
			panel1.Controls.Add(btnUpdate);
			panel1.Controls.Add(btnSave);
			panel1.Location = new Point(343, 365);
			panel1.Name = "panel1";
			panel1.Size = new Size(117, 193);
			panel1.TabIndex = 19;
			// 
			// AdminProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1120, 641);
			Controls.Add(btnFilter);
			Controls.Add(label8);
			Controls.Add(cbFilter);
			Controls.Add(groupBox1);
			Controls.Add(dgvAdProduct);
			Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AdminProduct";
			Text = "AdminProduct";
			Load += AdminProduct_Load;
			((System.ComponentModel.ISupportInitialize)dgvAdProduct).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
			((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
			panel1.ResumeLayout(false);
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
		private Button btnFilter;
		private Panel panel1;
	}
}