using ISpan.DessertStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.DessertShop.TinaWinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonConnectString_Click(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "myTest";
			SqlDb.ConnectTimeout = 99;
			SqlDb.Pooling = true;
			string connStr = SqlDb.GetConnectionString("default");

			MessageBox.Show(connStr);
		}

		private void buttonConnection_Click(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "conn test";
			SqlDb.Pooling = this.checkBoxPooling.Checked; // true  or false

			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				using (var command = new SqlCommand("SELECT * FROM Categories", conn))
				{
					conn.Open();

					var reader = command.ExecuteReader();
					reader.Close();
				}
			}
		}

		private void menuItemMaintainCategories_Click(object sender, EventArgs e)
		{
			FormCategoryEdit frm = new FormCategoryEdit();
			frm.ShowDialog();
		}

		private void menuItemMaintainProducts_Click(object sender, EventArgs e)
		{
			FormProduct frm = new FormProduct();
			frm.ShowDialog();
		}

		private void menuItemMaintainOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormOrder frm = new FormOrder();
			frm.ShowDialog();
		}
	}
}
