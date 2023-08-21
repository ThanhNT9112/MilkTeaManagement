namespace MilkTea
{
	partial class AdminMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			lbWelcome = new Label();
			btnLogOut = new Button();
			label1 = new Label();
			panel2 = new Panel();
			btnProfile = new Button();
			btnRevenue = new Button();
			btnBranch = new Button();
			button3 = new Button();
			btnProduct = new Button();
			button1 = new Button();
			mainPanel = new FlowLayoutPanel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.DodgerBlue;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(lbWelcome);
			panel1.Controls.Add(btnLogOut);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(3, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(1416, 74);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(30, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(46, 66);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// lbWelcome
			// 
			lbWelcome.AutoSize = true;
			lbWelcome.BackColor = Color.DodgerBlue;
			lbWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lbWelcome.ForeColor = SystemColors.Control;
			lbWelcome.Location = new Point(1066, 16);
			lbWelcome.Name = "lbWelcome";
			lbWelcome.Size = new Size(217, 38);
			lbWelcome.TabIndex = 4;
			lbWelcome.Text = "Welcome admin";
			lbWelcome.Click += lbWelcome_Click;
			// 
			// btnLogOut
			// 
			btnLogOut.BackColor = Color.DodgerBlue;
			btnLogOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogOut.ForeColor = SystemColors.ButtonHighlight;
			btnLogOut.Location = new Point(1289, 17);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Size = new Size(106, 38);
			btnLogOut.TabIndex = 3;
			btnLogOut.Text = "Log Out";
			btnLogOut.UseVisualStyleBackColor = false;
			btnLogOut.Click += btnLogOut_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(82, 23);
			label1.Name = "label1";
			label1.Size = new Size(148, 46);
			label1.TabIndex = 2;
			label1.Text = "Milk Tea";
			// 
			// panel2
			// 
			panel2.BackColor = Color.PeachPuff;
			panel2.Controls.Add(btnProfile);
			panel2.Controls.Add(btnRevenue);
			panel2.Controls.Add(btnBranch);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(btnProduct);
			panel2.Controls.Add(button1);
			panel2.Location = new Point(3, 92);
			panel2.Name = "panel2";
			panel2.Size = new Size(220, 779);
			panel2.TabIndex = 1;
			// 
			// btnProfile
			// 
			btnProfile.BackColor = SystemColors.Info;
			btnProfile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnProfile.Location = new Point(42, 536);
			btnProfile.Name = "btnProfile";
			btnProfile.Size = new Size(135, 45);
			btnProfile.TabIndex = 5;
			btnProfile.Text = "Profile";
			btnProfile.UseVisualStyleBackColor = false;
			btnProfile.Click += btnProfile_Click;
			// 
			// btnRevenue
			// 
			btnRevenue.BackColor = SystemColors.Info;
			btnRevenue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnRevenue.Location = new Point(42, 445);
			btnRevenue.Name = "btnRevenue";
			btnRevenue.Size = new Size(135, 44);
			btnRevenue.TabIndex = 4;
			btnRevenue.Text = "Revenue";
			btnRevenue.UseVisualStyleBackColor = false;
			btnRevenue.Click += btnRevenue_Click;
			// 
			// btnBranch
			// 
			btnBranch.BackColor = SystemColors.Info;
			btnBranch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnBranch.Location = new Point(42, 344);
			btnBranch.Name = "btnBranch";
			btnBranch.Size = new Size(135, 43);
			btnBranch.TabIndex = 3;
			btnBranch.Text = "Branch";
			btnBranch.UseVisualStyleBackColor = false;
			btnBranch.Click += btnBranch_Click;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.Info;
			button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(42, 235);
			button3.Name = "button3";
			button3.Size = new Size(135, 52);
			button3.TabIndex = 2;
			button3.Text = "Ingredient";
			button3.UseVisualStyleBackColor = false;
			// 
			// btnProduct
			// 
			btnProduct.BackColor = SystemColors.Info;
			btnProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnProduct.Location = new Point(42, 134);
			btnProduct.Name = "btnProduct";
			btnProduct.Size = new Size(135, 47);
			btnProduct.TabIndex = 1;
			btnProduct.Text = "Product";
			btnProduct.UseVisualStyleBackColor = false;
			btnProduct.Click += btnProduct_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Info;
			button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(42, 34);
			button1.Name = "button1";
			button1.Size = new Size(135, 46);
			button1.TabIndex = 0;
			button1.Text = "Home";
			button1.UseVisualStyleBackColor = false;
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(229, 92);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1190, 773);
			mainPanel.TabIndex = 5;
			// 
			// AdminMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1431, 877);
			Controls.Add(mainPanel);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "AdminMenu";
			Text = "AdminMenu";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Button button1;
		private Button btnBranch;
		private Button button3;
		private Button btnProduct;
		private Label lbWelcome;
		private Button btnLogOut;
		private Button btnRevenue;
		private FlowLayoutPanel mainPanel;
		private Button btnProfile;
		private PictureBox pictureBox1;
	}
}