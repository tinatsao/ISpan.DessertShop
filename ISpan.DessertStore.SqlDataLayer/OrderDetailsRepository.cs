using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class OrderDetailsRepository
	{
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, OrderDetailsFormVm> funcAssemblerOdFormVm = OrderDetailsFormVm.GetInstance;
		public Func<SqlDataReader, OrderDetailsIndexVm> funcAssemblerOdIndexVm = OrderDetailsIndexVm.GetInstance;

		public IEnumerable<OrderDetailsIndexVm> GetViewData(int OrderId)
		{
			string sql = $@"SELECT o.ID,p.ProductName,p.ProductFlavor,p.ProductSize,od.Qty,od.UnitPrice,od.Subtotal
FROM OrderDetails AS od
INNER JOIN Products AS p
ON od.ProductID = p.ID
INNER JOIN Orders AS o
ON o.ID = od.OrderID
Where  o.ID=@Id;";

			var parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = OrderId });

			return SqlDb.Search(funcConn, funcAssemblerOdIndexVm, sql,parameters.ToArray());
		}

		public OrderDetailsFormVm GetOrders(int orderId)
		{
			string sql = $@"SELECT  o.Id,od.OrderID,o.OrderDate ,m.LastName,m.FirstName,m.Mobile,o.LastName,o.FirstName,o.ContactNumber,
o.ShipAddress,o.InvoiceAddress,o.ShippingFee,o.TotalPrice,o.OrderStatus,o.TotalPrice
FROM OrderDetails AS od
INNER JOIN Orders AS o
ON od.OrderID=o.ID
INNER JOIN Members AS m
ON o.MemberID = m.ID
WHERE od.OrderID = {orderId}
GROUP BY o.Id,od.OrderID,o.OrderDate ,m.LastName,m.FirstName,m.Mobile,o.LastName,o.FirstName,o.ContactNumber,
o.ShipAddress,o.InvoiceAddress,o.ShippingFee,o.TotalPrice,o.OrderStatus,o.TotalPrice";


			var parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = orderId });

			return SqlDb.Get(funcConn, funcAssemblerOdFormVm, sql, parameters.ToArray());

		}
        public int Update(OrderDetailsFormVm entity)
        {
			var sql = $@"UPDATE Orders
SET  OrderStatus=N'已取消'
WHERE  ID = {entity.Id}";
				
            var parameters = SqlParameterBuilder.Create()
                .AddInt("ID", entity.Id)
                .Build();

            int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
            return rowsAffected;
        }

		
    }

	public class OrderDetailsFormVm
	{/// <summary>
	/// 畫面上方的欄位
	/// </summary>
		public int	Id	{ get; set; }
		public DateTime OrderDate { get; set; }
		public string OrderStatus { get; set; }
		public string MemberLastName { get; set; }
		public string MemberFirstName { get; set; }
		public string MobilePhone { get; set; }
		public string ContactLastName { get; set; }
		public string ContactFirstName { get; set; }
		public string ContactNumber { get; set; }

		public string ShipZIP { get; set; }
		public string ShipAddress { get; set; }
		public string InvoiceZIP { get; set; }
		public string InvoiceAddress { get; set; }
		public decimal ShippingFee { get; set; }
		public decimal Subtotal { get; set; }

		public static OrderDetailsFormVm GetInstance(SqlDataReader reader)
		{
			var entity = new OrderDetailsFormVm();
			//OrderTable
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.OrderDate = reader.GetFieldValue<DateTime>("OrderDate");
			entity.ContactLastName = reader.GetFieldValue<string>("LastName");
			entity.ContactFirstName = reader.GetFieldValue<string>("FirstName");
			entity.ContactNumber = reader.GetFieldValue<string>("ContactNumber");

			entity.OrderStatus = reader.GetFieldValue<string>("OrderStatus");
			//entity.ShipZIP = reader.GetFieldValue<string>("ShipZIP");
			entity.ShipAddress = reader.GetFieldValue<string>("ShipAddress");
			//entity.InvoiceZIP = reader.GetFieldValue<string>("InvoiceZIP");
			entity.InvoiceAddress = reader.GetFieldValue<string>("InvoiceAddress");

			//entity.ShippingFee = reader.GetFieldValue<decimal>("ShippingFee");
			entity.Subtotal = reader.GetFieldValue<decimal>("TotalPrice");

			//MemberTable
			entity.MemberLastName = reader.GetFieldValue<string>("LastName");
			entity.MemberFirstName = reader.GetFieldValue<string>("FirstName");
			entity.MobilePhone = reader.GetFieldValue<string>("Mobile");


			return entity;
		}
	}

	public class OrderDetailsIndexVm
	{/// <summary>
	 /// 畫面下方的表格
	 /// </summary>

		//OrderTable

		public int Id { get; set; }

		//ProtuctTable
		public string ProductName { get; set; }
		public string ProductFlavor { get; set; }
		public string ProductSize { get; set; }

		//OrderDetailTable
		public decimal Qty { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Subtotal { get; set; }

		public static OrderDetailsIndexVm GetInstance(SqlDataReader reader)
		{
			var entity = new OrderDetailsIndexVm();
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.ProductName = reader.GetFieldValue<string>("ProductName");
			entity.ProductFlavor = reader.GetFieldValue<string>("ProductFlavor");
			entity.ProductSize = reader.GetFieldValue<string>("ProductSize");
			entity.Qty = reader.GetFieldValue<decimal>("Qty");

			entity.UnitPrice = reader.GetFieldValue<decimal>("UnitPrice");
			entity.Subtotal = reader.GetFieldValue<decimal>("Subtotal");

			return entity;
		}

	}
}
