using Project_PRN211.Models;
using Project_PRN211.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUsername.Text;
			string passWord = txtPassword.Text;
			if (Login(userName, passWord))
			{
				Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
				frmTable f = new frmTable(loginAccount);
				this.Hide();
				f.ShowDialog();
			//	this.Show();
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
			}
		}

		bool Login(string userName, string passWord)
		{
			return AccountDAO.Instance.Login(userName, passWord);
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
