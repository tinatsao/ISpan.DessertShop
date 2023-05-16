using ISpan.DessertStore.SqlDataLayer;
using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.DessertShop.TinaWinForms
{
	public partial class FormOrder : Form, IGridContainer
	{
		private OrdersRepository repo;
		private List<OrderIndexVm> _orderIndexVm;

		public string SOrderID => textBoxID.Text;
		public string SAccount => textBoxMemberAccount.Text;
		public string SOrderStatus => comboBoxOrderStatus.Text != "select..." ? comboBoxOrderStatus.Text : string.Empty;
		//{
		//	get { return comboBoxOrderStatus.Text != "...select" ? comboBoxOrderStatus.Text : string.Empty;}
		//}
				
			//=> ()comboBoxOrderStatus.Text;//待改
		public DateTime SDateStart => this.dateTimePickerOrderDateStart.Value;
		public DateTime SDateEnd => this.dateTimePickerOrderDateEnd.Value;

		private List<OrderIndexVm> _orders;
		public FormOrder()
		{
			InitializeComponent();
			repo = new OrdersRepository();
			comboBoxOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Load += FormOrder_Load;
			
		}

		private void FormOrder_Load(object sender, EventArgs e)
		{
			Display();

			// 初始化下拉清單內容

			// 在最前面加一個空白項
			

			List<string> OrderstatusList = new List<string>
			{
				"select...",
				"未出貨",
				"已出貨",
				"已完成",
				"已取消"
			};

			comboBoxOrderStatus.DataSource = OrderstatusList;
			comboBoxOrderStatus.SelectedIndex = 0;
		}

		public void Display()
		{
			_orders = repo.Search(SOrderID, SAccount, SOrderStatus, SDateStart, SDateEnd).ToList();

			var query = _orders.Select((a, index) => new { SNO = index+1, a.Id,a.Account, a.OrderDate, a.LastName,a.FirstName,a.Mobile,a.Email,a.TotalPrice,a.PaymentMethod,a.OrderStatus}).ToList();
			//foreach (var obj in query)
			//{
			//	MessageBox.Show(obj.ToString());
			//}
			
			dataGridView1.DataSource = query;
			//int rowIndex = 0;

			//foreach (DataGridViewRow row in dataGridView1.Rows)
			//{
			//	row.Cells["OrdersItem"].Value = ++rowIndex;
			//}

		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		// 宣告一個 DataGridViewButtonColumn 物件

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["OrderDetailView"].Index)
			{
				int orderId = _orders[e.RowIndex].Id;
				
				var frm = new FormOrderDetail(orderId);
				frm.Owner = this;
				frm.ShowDialog();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
//_orderIndexVm[e.RowIndex].Id