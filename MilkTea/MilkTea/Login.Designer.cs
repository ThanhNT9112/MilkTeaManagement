namespace MilkTea
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

<<<<<<< HEAD
		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.Control;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Highlight;
			label1.Location = new Point(475, 126);
			label1.Name = "label1";
			label1.Size = new Size(248, 46);
			label1.TabIndex = 0;
			label1.Text = "Welcome User";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.Highlight;
			label2.Location = new Point(374, 306);
			label2.Name = "label2";
			label2.Size = new Size(133, 31);
			label2.TabIndex = 1;
			label2.Text = "Username :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.Highlight;
			label3.Location = new Point(374, 420);
			label3.Name = "label3";
			label3.Size = new Size(126, 31);
			label3.TabIndex = 2;
			label3.Text = "Password :";
			// 
			// txtUsername
			// 
			txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.Location = new Point(374, 345);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(415, 43);
			txtUsername.TabIndex = 3;
	
			// 
			// txtPassword
			// 
			txtPassword.Anchor = AnchorStyles.None;
			txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(374, 465);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(415, 38);
			txtPassword.TabIndex = 4;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = SystemColors.Highlight;
			btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.ForeColor = SystemColors.Control;
			btnLogin.Location = new Point(475, 540);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(229, 41);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1179, 677);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Login";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}
=======
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(447, 122);
            label1.Name = "label1";
            label1.Size = new Size(301, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome MilkTea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(374, 234);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(374, 340);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(374, 280);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(415, 43);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(374, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(415, 38);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Info;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Desktop;
            btnLogin.Location = new Point(468, 447);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 51);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 677);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
>>>>>>> 5bf8e0a03a91988c36ad81478828f95fc13912b8

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
	}
}