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
			panel1 = new Panel();
			lbWelcome = new Label();
			btnLogOut = new Button();
			label1 = new Label();
			panel2 = new Panel();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			button5 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Highlight;
			panel1.Controls.Add(lbWelcome);
			panel1.Controls.Add(btnLogOut);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(3, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(1350, 74);
			panel1.TabIndex = 0;
			// 
			// lbWelcome
			// 
			lbWelcome.AutoSize = true;
			lbWelcome.BackColor = SystemColors.Highlight;
			lbWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			lbWelcome.ForeColor = SystemColors.Control;
			lbWelcome.Location = new Point(990, 16);
			lbWelcome.Name = "lbWelcome";
			lbWelcome.Size = new Size(217, 38);
			lbWelcome.TabIndex = 4;
			lbWelcome.Text = "Welcome admin";
			lbWelcome.Click += lbWelcome_Click;
			// 
			// btnLogOut
			// 
			btnLogOut.BackColor = SystemColors.Highlight;
			btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogOut.ForeColor = SystemColors.Control;
			btnLogOut.Location = new Point(1243, 24);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Size = new Size(94, 29);
			btnLogOut.TabIndex = 3;
			btnLogOut.Text = "LogOut";
			btnLogOut.UseVisualStyleBackColor = false;
			btnLogOut.Click += btnLogOut_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(81, 11);
			label1.Name = "label1";
			label1.Size = new Size(148, 46);
			label1.TabIndex = 2;
			label1.Text = "Milk Tea";
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Highlight;
			panel2.Controls.Add(button5);
			panel2.Controls.Add(button4);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button1);
			panel2.Location = new Point(3, 92);
			panel2.Name = "panel2";
			panel2.Size = new Size(220, 572);
			panel2.TabIndex = 1;
			// 
			// button4
			// 
			button4.Location = new Point(55, 349);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 3;
			button4.Text = "Brand";
			button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(55, 243);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 2;
			button3.Text = "Ingredient";
			button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(55, 139);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 1;
			button2.Text = "Product";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(55, 38);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "Home";
			button1.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(55, 456);
			button5.Name = "button5";
			button5.Size = new Size(94, 29);
			button5.TabIndex = 4;
			button5.Text = "Revenue";
			button5.UseVisualStyleBackColor = true;
			// 
			// AdminMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1352, 666);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "AdminMenu";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Button button1;
		private Button button4;
		private Button button3;
		private Button button2;
		private Label lbWelcome;
		private Button btnLogOut;
		private Button button5;
	}
}