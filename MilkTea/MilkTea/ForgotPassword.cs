using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MilkTea
{

	public partial class ForgotPassword : Form
	{
		private readonly MilkteaDBContext db = new MilkteaDBContext();
		public ForgotPassword()
		{
			InitializeComponent();
		}
		Random rd = new Random();
		int otp;
		private string username;
		private string email;

		private static readonly string _from = "tungdqhe161511@fpt.edu.vn"; // Email của Sender (của bạn)
		private static readonly string _pass = "eujdtujrjpfzcrup"; // Mật khẩu Email của Sender (của bạn)
		private void btnSendOTP_Click(object sender, EventArgs e)
		{
			username = txtUsername.Text;
			email = txtEmail.Text;


			try
			{
				otp = rd.Next(10000, 1000000);
				string username = txtUsername.Text;

				var user = db.Accounts.FirstOrDefault(x => x.Username == username);
				if (user == null)
				{
					MessageBox.Show("Try again");
					return;
				}
				if (email != _from)
				{

					MessageBox.Show("try again");
					return;
				}



				MailMessage mail = new MailMessage();

				mail.From = new MailAddress(_from);
				mail.To.Add("tungdqhe161511@fpt.edu.vn");
				mail.Subject = "OTP";
				mail.IsBodyHtml = true;
				mail.Body = otp.ToString();

				mail.Priority = MailPriority.High;

				SmtpClient smtp = new SmtpClient("smtp.gmail.com");

				smtp.Port = 587;
				smtp.Credentials = new System.Net.NetworkCredential(_from, _pass);
				smtp.EnableSsl = true;


				smtp.Send(mail);
				MessageBox.Show("OTP đã được gửi");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtSubmit_Click(object sender, EventArgs e)
		{
			int enteredOTP = int.Parse(txtOTP.Text);

			if (enteredOTP == otp)
			{
				// OTP đúng
				MessageBox.Show("OTP is correct");

				ChangePassword formChangePassword = new ChangePassword(); // Tạo và hiển thị form ChangePassword
				formChangePassword.Show();
				this.Hide();

			}
			else
			{
				// OTP sai
				MessageBox.Show("OTP is incorrect");

				// Xử lý khi OTP sai (ví dụ: thông báo cho người dùng nhập lại OTP)
				return;
			}



		}
	}
}

