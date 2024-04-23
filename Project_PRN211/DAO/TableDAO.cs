using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_PRN211.DAO
{
	public class TableDAO
	{
		private static TableDAO instance;

		public static TableDAO Instance
		{
			get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
			private set { TableDAO.instance = value; }
		}

		private TableDAO() { }


		public List<TableFood> LoadTableList()
		{
			List<TableFood> tableList = new List<TableFood>();

			DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableFood");

			foreach (DataRow item in data.Rows)
			{
				TableFood table = new TableFood(item);
				tableList.Add(table);
			}

			return tableList;
		}

		public void UpdateStatusTable(int id, int status)
		{
			if (status == 1)
			{
				DataProvider.Instance.ExecuteQuery("UPDATE [dbo].[TableFood] SET [status] = N'Có người' WHERE id = " + id);
			}
			else if (status == 0)
			{
				DataProvider.Instance.ExecuteQuery("UPDATE [dbo].[TableFood] SET [status] = N'Trống' WHERE id = " + id);
			}
		}
		public bool UpdateTable(int id, string name, string status)
		{
			string query = string.Format("UPDATE [dbo].[TableFood] SET [name] = N'{0}', [status] = N'{2}'  WHERE id={1} ", name, id, status);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
		public bool DeactiveTable(int id)
		{
			if (checkBillExist(id))
			{
				return false;
			}
			else
			{
				string query = string.Format("UPDATE[dbo].[TableFood] SET[status] = N'Không hoạt động' WHERE id = " + id);
				int result = DataProvider.Instance.ExecuteNonQuery(query);

				return result > 0;
			}

		}
		public bool checkExist(string name)
		{
			string query = string.Format("SELECT COUNT(*) FROM [dbo].[TableFood] WHERE name = N'{0}'", name);
			int result = (int)DataProvider.Instance.ExecuteScalar(query);
			return result > 0;
		}

		public bool InsertTable(string name)
		{
			if (checkExist(name))
			{
				return false;
			}
			else
			{
				string query = string.Format("INSERT INTO [dbo].[TableFood] ([name],[status]) VALUES('{0}', N'Trống')", name);
				int result = DataProvider.Instance.ExecuteNonQuery(query);
				return result > 0;
			}
		}

		public bool checkBillExist(int id)
		{
			string query = string.Format("SELECT COUNT(*) FROM [dbo].[TableFood] WHERE id = '{0}' and status = N'Có người'", id);
			int result = (int)DataProvider.Instance.ExecuteScalar(query);
			return result > 0;
		}

		public bool DeleteTable(int id)
		{
			if (checkBillExist(id))
			{
				return false;
			}
			else
			{
				string query = string.Format("DELETE FROM [dbo].[TableFood] WHERE id={0}", id);
				int result = DataProvider.Instance.ExecuteNonQuery(query);

				return result > 0;
			}

		}
	}
}
