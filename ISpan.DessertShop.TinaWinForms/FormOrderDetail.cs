using ISpan.DessertStore.SqlDataLayer;
using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ISpan.DessertShop.TinaWinForms
{
	public partial class FormOrderDetail : Form, IGridContainer
	{
		private OrderDetailsRepository repo;
		private List<OrderDetailsFormVm> _orderDetailsFormVm;
		private List<OrderDetailsIndexVm> _orderDetailsIndexVm;

		private readonly int orderID;


		public FormOrderDetail(int orderId)
		{
			InitializeComponent();
			
			this.orderID = orderId;
		}

		private void FormOrderDetail_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			var orderdetail = new OrderDetailsRepository().GetViewData(orderID).ToList();//下方顯示的資料
			var order = new OrderDetailsRepository().GetOrders(orderID);//上方顯示的資料
			BindForm(order);//讀取上方顯示資料的欄位
			dataGridView1.DataSource = orderdetail;//下方顯示的資料
        }
		private void BindForm(OrderDetailsFormVm orders)
		{
			textBoxOrderID.Text = orders.Id.ToString();
			textBoxOrderDate.Text = orders.OrderDate.ToShortDateString();
			textBoxOrderStatus.Text = orders.OrderStatus;

			textBoxMemberLastName.Text = orders.MemberLastName;
			textBoxMemberFirstName.Text = orders.MemberFirstName;
			textBoxMemberMobile.Text = orders.MobilePhone;

			this.textBoxContactLastName.Text = orders.ContactLastName;
			this.textBoxContactFirstName.Text = orders.ContactFirstName;
			textBoxContactNumber.Text = orders.ContactNumber;


			this.textBoxShipAddress.Text = orders.ShipAddress;
			this.textBoxInvoiceAddress.Text = orders.InvoiceAddress;
			textBoxSubTotal.Text = orders.Subtotal.ToString();
		}

		private void buttonCancelOrder_Click(object sender, EventArgs e)
		{
            //未出貨/已出貨/已完成/已取消
            //todo 更新訂單狀態 成為 已取消。假如訂單不是已完成或已出貨的狀態

            var order = new OrderDetailsRepository().GetOrders(orderID);

            if (order.OrderStatus =="未出貨")
			{
                var model = GetModel();
                new OrderDetailsRepository().Update(model);
                IGridContainer container = this.Owner as IGridContainer;
                if (container != null) container.Display();

                MessageBox.Show("訂單「已取消」","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Display();
            }
			else if(order.OrderStatus == "已完成" || order.OrderStatus == "已出貨")
			{
				MessageBox.Show($"訂單「{order.OrderStatus}」,\r\n不可取消訂單","提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }



		private OrderDetailsFormVm GetModel() => new OrderDetailsFormVm
		{
            Id = this.orderID,
        };
    }
}
