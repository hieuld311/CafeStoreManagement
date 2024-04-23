using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_PRN211.DAO;
using Project_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_PRN211.frmAccountProfile;

namespace Project_PRN211
{
	public partial class frmTable : Form
	{
		private Account loginAccount;

		public Account LoginAccount
		{
			get { return loginAccount; }
			set { loginAccount = value; ChangeAccount(loginAccount.Type); }
		}
		public frmTable(Account account)
		{
			InitializeComponent();
			this.loginAccount = account;
			LoadTable();
			LoadCategory();
			ChangeAccount(account.Type);

		}
		void ChangeAccount(int type)
		{
			if (type == 1)
			{
				adminToolStripMenuItem.Enabled = true;
			}
			else
			{
				adminToolStripMenuItem.Enabled = false;
			}
			thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
		}
		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAdmin f = new frmAdmin();
			f.loginAccount = LoginAccount;
			f.InsertFood += f_InsertFood;
			f.DeleteFood += f_DeleteFood;
			f.UpdateFood += f_UpdateFood;
			f.ShowDialog();
		}
		void LoadCategory()
		{
			List<FoodCategory> listCategory = CategoryDAO.Instance.GetListCategory();
			cbxCategory.DataSource = listCategory;
			cbxCategory.DisplayMember = "Name";
		}
		void LoadFoodByCateId(int id)
		{
			List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
			cbxFood.DataSource = listFood;
			cbxFood.DisplayMember = "Name";
		}
		void LoadTable()
		{
			flpTable.Controls.Clear();
			List<TableFood> list = TableDAO.Instance.LoadTableList();
			foreach (TableFood table in list)
			{
				Button btn = new Button() { Width = 90, Height = 90 };
				btn.Text = table.Name + Environment.NewLine + table.Status;
				btn.Click += Btn_Click;
				btn.Tag = table;
				switch (table.Status)
				{
					case "Trống":
						btn.BackColor = Color.LightCyan;
						break;
					case "Có người":
						btn.BackColor = Color.YellowGreen;
						break;
					default:
						btn.Enabled = false;
						btn.BackColor = Color.DarkCyan;
						break;
				}
				flpTable.Controls.Add(btn);
			}
		}
		void ShowBillByTableID(int id)
		{
			lsvBill.Items.Clear();
			List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTableId(id);
			float totalPrice = 0;
			foreach (Menu item in listBillInfo)
			{
				ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());
				totalPrice += item.TotalPrice;
				lsvBill.Items.Add(lsvItem);
			}
			CultureInfo culture = new CultureInfo("vi-VN"); //đùng để set đơn vị tiền, ở đây là theo tiền Việt (đ)

			Thread.CurrentThread.CurrentCulture = culture; // chỉ áp dụng culture việt cho thread này

			txtTotalPrice.Text = totalPrice.ToString("c", culture);
		}
		private void Btn_Click(object? sender, EventArgs e)
		{
			int tableID = ((sender as Button).Tag as TableFood).Id;
			lsvBill.Tag = (sender as Button).Tag;
			ShowBillByTableID(tableID);
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAccountProfile f = new frmAccountProfile(LoginAccount);
			f.UpdateAccount += f_UpdateAccount;
			f.ShowDialog();
		}

		private void f_UpdateFood(object? sender, EventArgs e)
		{
			LoadFoodByCateId((cbxCategory.SelectedItem as FoodCategory).Id);
			if (lsvBill.Tag != null)
				ShowBillByTableID((lsvBill.Tag as TableFood).Id);
		}

		private void f_DeleteFood(object? sender, EventArgs e)
		{
			LoadFoodByCateId((cbxCategory.SelectedItem as FoodCategory).Id);
			if (lsvBill.Tag != null)
				ShowBillByTableID((lsvBill.Tag as TableFood).Id);
			LoadTable();
		}

		private void f_InsertFood(object? sender, EventArgs e)
		{
			LoadFoodByCateId((cbxCategory.SelectedItem as FoodCategory).Id);
			if (lsvBill.Tag != null)
				ShowBillByTableID((lsvBill.Tag as TableFood).Id);
		}

		void f_UpdateAccount(object sender, AccountEvent e)
		{
			thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
		}


		private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;

			ComboBox cbx = sender as ComboBox;

			if (cbx.SelectedItem == null)
				return;

			FoodCategory selected = cbx.SelectedItem as FoodCategory;
			id = selected.Id;

			LoadFoodByCateId(id);
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			TableFood table = lsvBill.Tag as TableFood;
			if (table == null)
			{
				MessageBox.Show("Hãy chọn bàn");
				return;
			}
			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
			int foodId = (cbxFood.SelectedItem as Food).Id;
			int count = (int)nudFoodCount.Value;

			if (idBill == -1) // Tức bàn này chưa có bill (GetUncheckBillIDByTableID)
			{
				BillDAO.Instance.InsertBill(table.Id);
				BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodId, count);  //tạo bill info mới với id = id max của bill info vì id của bill info auto increment
			}
			else
			{
				BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
			}
			ShowBillByTableID(table.Id);
			if (lsvBill.Items.Count > 0)
			{
				TableDAO.Instance.UpdateStatusTable(table.Id, 1);
			}
			else
			{
				TableDAO.Instance.UpdateStatusTable(table.Id, 0);
			}
			LoadTable();
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			TableFood table = lsvBill.Tag as TableFood;

			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
			int discount = (int)nudDiscount.Value;

			double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('.')[0]) * 1000; ;
			double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

			if (idBill != -1)
			{
				if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice, (loginAccount.UserName).ToString());
					ShowBillByTableID(table.Id);
					TableDAO.Instance.UpdateStatusTable(table.Id, 0);
					LoadTable();
				}
			}
		}

		private void flpTable_Paint(object sender, PaintEventArgs e)
		{

		}

		private void frmTable_Load(object sender, EventArgs e)
		{

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadTable();
		}
	}
}
