namespace MilkTea
{
	partial class AdminStatic
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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(336, 26);
			label1.Name = "label1";
			label1.Size = new Size(421, 41);
			label1.TabIndex = 0;
			label1.Text = "Static Form. Branches Revenue";
			// 
			// AdminStatic
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1129, 633);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AdminStatic";
			Text = "AdminStatic";
			Load += AdminStatic_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
	}
}