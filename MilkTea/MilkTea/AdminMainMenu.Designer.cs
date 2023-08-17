namespace MilkTea
{
	partial class AdminMainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenu));
			TopPanel = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			panel2 = new Panel();
			LeftPanel = new Panel();
			button2 = new Button();
			button1 = new Button();
			panelDetail = new Panel();
			TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			LeftPanel.SuspendLayout();
			SuspendLayout();
			// 
			// TopPanel
			// 
			TopPanel.BackColor = SystemColors.Info;
			TopPanel.Controls.Add(pictureBox1);
			TopPanel.Controls.Add(label1);
			TopPanel.Controls.Add(panel2);
			TopPanel.Location = new Point(0, 1);
			TopPanel.Name = "TopPanel";
			TopPanel.Size = new Size(1291, 125);
			TopPanel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(25, 21);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(44, 71);
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(75, 30);
			label1.Name = "label1";
			label1.Size = new Size(196, 62);
			label1.TabIndex = 6;
			label1.Text = "Milk Tea";
			// 
			// panel2
			// 
			panel2.Location = new Point(0, 131);
			panel2.Name = "panel2";
			panel2.Size = new Size(250, 125);
			panel2.TabIndex = 1;
			// 
			// LeftPanel
			// 
			LeftPanel.BackColor = SystemColors.ButtonHighlight;
			LeftPanel.Controls.Add(button2);
			LeftPanel.Controls.Add(button1);
			LeftPanel.Location = new Point(3, 132);
			LeftPanel.Name = "LeftPanel";
			LeftPanel.Size = new Size(231, 590);
			LeftPanel.TabIndex = 1;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(22, 245);
			button2.Name = "button2";
			button2.Size = new Size(151, 68);
			button2.TabIndex = 0;
			button2.Text = "Static";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(22, 38);
			button1.Name = "button1";
			button1.Size = new Size(151, 71);
			button1.TabIndex = 0;
			button1.Text = "Home";
			button1.UseVisualStyleBackColor = true;
			// 
			// panelDetail
			// 
			panelDetail.Location = new Point(240, 132);
			panelDetail.Name = "panelDetail";
			panelDetail.Size = new Size(1051, 590);
			panelDetail.TabIndex = 2;
			// 
			// AdminMainMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1303, 734);
			Controls.Add(panelDetail);
			Controls.Add(LeftPanel);
			Controls.Add(TopPanel);
			Name = "AdminMainMenu";
			Text = "AdminMainMenu";
			TopPanel.ResumeLayout(false);
			TopPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			LeftPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel TopPanel;
		private Label label1;
		private Panel panel2;
		private Panel LeftPanel;
		private Panel panelDetail;
		private PictureBox pictureBox1;
		private Button button2;
		private Button button1;
	}
}