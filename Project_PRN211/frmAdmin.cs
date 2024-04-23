using Microsoft.Data.SqlClient;
using Project_PRN211.DAO;
using Project_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_PRN211
{
	public partial class frmAdmin : Form
	{
		BindingSource foodlist = new BindingSource();
		BindingSource accountList = new BindingSource();
		BindingSource cateList = new BindingSource();
		BindingSource tableList = new BindingSource();
		public Account loginAccount;
		public frmAdmin()
		{
			InitializeComponent();
			Load();
		}
		void Load()
		{
			LoadListBillByDate(dtbFromDate.Value, dtbToDate.Value);
			LoadCategoryIntoCombobox(cbxCategory);
			LoadListFood();
			LoadAccount();
			LoadListCategory();
			LoadListTable();
			AddFoodBinding();
			AddAccountBinding();
			AddCateBinding();
			AddTableBinding();
		}
		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

		}
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtbFromDate.Value, dtbToDate.Value);
		}

		private void btnViewFood_Click(object sender, EventArgs e)
		{
			LoadListFood();
		}
		void LoadListTable()
		{
			tableList.DataSource = TableDAO.Instance.LoadTableList();
			dgvTable.DataSource = tableList;
			dgvTable.Columns["Bills"].Visible = false;
		}
		void LoadListCategory()
		{
			cateList.DataSource = CategoryDAO.Instance.GetListCategory();
			dgvCategory.DataSource = cateList;
			dgvCategory.Columns["Foods"].Visible = false;
		}
		void LoadListFood()
		{
			dgvFood.DataSource = foodlist;
			foodlist.DataSource = FoodDAO.Instance.GetListFood();
		}
		void LoadAccount()
		{
			dgvAccount.DataSource = accountList;
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}
		void AddCateBinding()
		{
			txtCategoryID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
			txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
		}
		void AddTableBinding()
		{
			txtTableID.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
			txtTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
			cbxTableStatus.DataSource = new List<string> { "Trống", "Có người", "Không hoạt động" };
			cbxTableStatus.DataBindings.Add(new Binding("SelectedItem", dgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
		}
		void AddAccountBinding()
		{
			txtAccountUsername.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txtAccountDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			nudAccountType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}
		void AddFoodBinding()
		{
			txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
			txtIdFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
			nudPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
		}

		void LoadCategoryIntoCombobox(ComboBox cbx)
		{
			cbx.DataSource = CategoryDAO.Instance.GetListCategory();
			cbx.DisplayMember = "Name";
		}
		private void txtFoodID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (dgvFood.SelectedCells.Count > 0)
				{
					int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

					FoodCategory category = CategoryDAO.Instance.GetCategoryByID(id);

					cbxCategory.SelectedItem = category;

					int index = -1;
					int i = 0;
					foreach (FoodCategory item in cbxCategory.Items)
					{
						if (item.Id == category.Id)
						{
							index = i;
							break;
						}
						i++;
					}

					cbxCategory.SelectedIndex = index;
				}
			}
			catch { }
		}
		private event EventHandler insertFood;
		public event EventHandler InsertFood
		{
			add { insertFood += value; }
			remove { insertFood -= value; }
		}
		private void btnAddFood_Click(object sender, EventArgs e)
		{
			string name = txtFoodName.Text;
			int categoryID = (cbxCategory.SelectedItem as FoodCategory).Id;
			float price = (float)nudPrice.Value;

			if (FoodDAO.Instance.InsertFood(name, categoryID, price))
			{
				MessageBox.Show("Thêm món thành công");
				LoadListFood();
				if (insertFood != null)
					insertFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm thức ăn");
			}
		}
		private event EventHandler updateFood;
		public event EventHandler UpdateFood
		{
			add { updateFood += value; }
			remove { updateFood -= value; }
		}
		private void btnUpdateFood_Click(object sender, EventArgs e)
		{
			string name = txtFoodName.Text;
			int categoryID = (cbxCategory.SelectedItem as FoodCategory).Id;
			float price = (float)nudPrice.Value;
			int id = Convert.ToInt32(txtIdFood.Text);

			if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
			{
				MessageBox.Show("Sửa món thành công");
				LoadListFood();
				if (updateFood != null)
					updateFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa thức ăn");
			}
		}
		private event EventHandler deleteFood;
		public event EventHandler DeleteFood
		{
			add { deleteFood += value; }
			remove { deleteFood -= value; }
		}

		private void btnDeleteFood_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtIdFood.Text);

			if (FoodDAO.Instance.DeleteFood(id))
			{
				MessageBox.Show("Xóa món thành công");
				LoadListFood();
				if (deleteFood != null)
					deleteFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa thức ăn");
			}
		}
		List<Food> SearchFoodByName(string name)
		{
			List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

			return listFood;
		}
		private void btnSearchFood_Click(object sender, EventArgs e)
		{
			foodlist.DataSource = SearchFoodByName(txtFoodNameSearch.Text);
		}

		private void btnViewAccount_Click(object sender, EventArgs e)
		{
			LoadAccount();
		}
		void AddAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
			{
				MessageBox.Show("Thêm tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản thất bại");
			}

			LoadAccount();
		}
		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			string userName = txtAccountUsername.Text;
			string displayName = txtAccountDisplayName.Text;
			int type = (int)nudAccountType.Value;

			AddAccount(userName, displayName, type);
		}

		void EditAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
			{
				MessageBox.Show("Cập nhật tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Cập nhật tài khoản thất bại");
			}

			LoadAccount();
		}

		private void btnUpdateAccount_Click(object sender, EventArgs e)
		{
			string userName = txtAccountUsername.Text;
			string displayName = txtAccountDisplayName.Text;
			int type = (int)nudAccountType.Value;

			EditAccount(userName, displayName, type);
		}

		void DeleteAccount(string userName)
		{
			if (loginAccount.UserName.Equals(userName))
			{
				MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
				return;
			}
			if (AccountDAO.Instance.DeleteAccount(userName))
			{
				MessageBox.Show("Xóa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Xóa tài khoản thất bại");
			}

			LoadAccount();
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			string userName = txtAccountUsername.Text;

			DeleteAccount(userName);
		}

		void ResetPass(string userName)
		{
			if (AccountDAO.Instance.ResetPassword(userName))
			{
				MessageBox.Show("Đặt lại mật khẩu thành công");
			}
			else
			{
				MessageBox.Show("Đặt lại mật khẩu thất bại");
			}
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			string userName = txtAccountUsername.Text;

			ResetPass(userName);
		}

		private void btnViewCategory_Click(object sender, EventArgs e)
		{
			LoadListCategory();
		}

		private void btnViewTable_Click(object sender, EventArgs e)
		{
			LoadListTable();
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtCategoryID.Text);

			if (CategoryDAO.Instance.DeleteCategory(id))
			{
				MessageBox.Show("Xóa danh mục thành công");
				LoadListCategory();
				LoadCategoryIntoCombobox(cbxCategory);
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa danh mục");
			}
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			string name = txtCategoryName.Text;
			AddCate(name);
		}
		void AddCate(string name)
		{
			if (CategoryDAO.Instance.InsertCategory(name))
			{
				MessageBox.Show("Thêm danh mục thành công");
			}
			else
			{
				MessageBox.Show("Thêm danh mục thất bại");
			}
			LoadListCategory();
			LoadCategoryIntoCombobox(cbxCategory);
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtCategoryID.Text);
			string name = txtCategoryName.Text;
			UpdateCate(id, name);
		}
		void UpdateCate(int id, string name)
		{
			if (CategoryDAO.Instance.UpdateCategory(id, name))
			{
				MessageBox.Show("Sửa danh mục thành công");
			}
			else
			{
				MessageBox.Show("Sửa danh mục thất bại");
			}
			LoadCategoryIntoCombobox(cbxCategory);
			LoadListCategory();
		}

		void AddTable(string name)
		{
			if (TableDAO.Instance.InsertTable(name))
			{
				MessageBox.Show("Thêm bàn thành công");
			}
			else
			{
				MessageBox.Show("Thêm bàn thất bại");
			}
			LoadListTable();
		}

		void UpdateTable(int id, string name, string status)
		{
			if (TableDAO.Instance.UpdateTable(id, name, status))
			{
				MessageBox.Show("Sửa bàn thành công");
			}
			else
			{
				MessageBox.Show("Sửa bàn thất bại");
			}
			LoadListTable();
		}

		void DeleteTable(int id)
		{
			if (TableDAO.Instance.DeleteTable(id))
			{
				MessageBox.Show("Xóa bàn thành công");
			}
			else
			{
				MessageBox.Show("Xóa bàn thất bại");
			}
			LoadListTable();
		}

		private void btnUpdateTable_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtTableID.Text);
			String name = txtTableName.Text;
			String status = cbxTableStatus.Text;
			UpdateTable(id, name, status);
		}

		private void btnAddTable_Click(object sender, EventArgs e)
		{
			String name = txtTableName.Text;
			AddTable(name);
		}

		private void btnDeleteTable_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtTableID.Text);
			DeleteTable(id);
		}

		private void cbxTableStatus_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
