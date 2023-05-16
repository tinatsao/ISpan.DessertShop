//using ISpan.DessertStore.SqlDataLayer.CodeFirst;
using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class OrdersRepository
	{
		private readonly string _tableName = "Orders";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, OrderIndexVm> funcAssemblerIndexVm = OrderIndexVm.GetInstance;
		public Func<SqlDataReader, OrderStatusVm> funcAssemblerOrderIndexVm = OrderStatusVm.GetInstance;

		public IEnumerable<OrderIndexVm> Search(string orderId, string account,string orderstatus, DateTime orderDateStart, DateTime orderDateEnd)
		{
			#region 生成SQL 陳述式
			string sql = $@"SELECT o.ID,m.Account,o.OrderDate,m.LastName,m.FirstName,m.Mobile,m.Email,o.TotalPrice,o.PaymentMethod,o.OrderStatus
FROM {_tableName} AS o
INNER JOIN  Members AS m
ON o.MemberID =  m.ID";

			//p.Id,p.ProductName ,c.Name AS CategoryName,Picture1,p.UnitPrice,p.Description,
			//p.UnitsInStock,p.ProductStatus,p.ProductUnit
			#endregion
			#region 生成where子句
			string where = string.Empty;
			var parameters = new List<SqlParameter>();//SQL參數
			if (string.IsNullOrEmpty(orderId) == false)
			{
				where += $" AND o.ID = @ID  ";

				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int) { Value = orderId });
			}
			if (string.IsNullOrEmpty(account) == false)
			{
				where += $" AND m.Account = @Account";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account });
			}
			if (string.IsNullOrEmpty(orderstatus) == false)
			{
				where += $" AND o.OrderStatus = @OrderStatus ";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@OrderStatus", System.Data.SqlDbType.NVarChar, 50) { Value = orderstatus });
			}
			//if (DateTime.IsNullOrEmpty(orderDateStart) == false)
			if(true)
			{
				where += $" AND o.OrderDate >= @OrderDateStart ";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@OrderDateStart", System.Data.SqlDbType.DateTime) { Value = orderDateStart});
			}
            //if (DateTime.IsNullOrEmpty(orderDateEnd) == false)
            if (true)
            {
				where += $" AND o.OrderDate < @OrderDateEnd ";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@OrderDateEnd", System.Data.SqlDbType.DateTime) { Value = orderDateEnd.AddDays(1) });
			}
			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;
			sql += $" ORDER BY(o.ID);";
			#endregion
			return SqlDb.Search(funcConn, funcAssemblerIndexVm, sql, parameters.ToArray());
		}

		public IEnumerable<OrderStatusVm> GetOrdersStatus()
		{

			string sql = $@"SELECT o.id, o.OrderStatus
FROM {_tableName} AS o
INNER JOIN  Members AS m
ON o.MemberID =  m.ID;";


			var parameters = new List<SqlParameter>();

			return SqlDb.Search(funcConn, funcAssemblerOrderIndexVm, sql, parameters.ToArray());
		}

	}

	public class OrderIndexVm
	{
		private DateTime _orderdate;
		//OrderTable
		public int Id { get; set; }

		public DateTime OrderDate 
		{
			get 
			{ 
				DateTime dt = new DateTime(_orderdate.Year, _orderdate.Month, _orderdate.Day);
				return dt;
			}
			set { _orderdate = value ; }
		}

		public decimal TotalPrice { get; set; }

		public string PaymentMethod { get; set; }
		public string OrderStatus { get; set; }

		
		//public Nullable<System.DateTime> CompletionDate { get; set; }




		//MemberTable

		public string Account { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }

		//private int _int = 0;
		//public int Item => _int ++;




		public static OrderIndexVm GetInstance(SqlDataReader reader)
		{
			var entity = new OrderIndexVm();
			//OrderTable
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.OrderDate = reader.GetFieldValue<DateTime>("OrderDate");
			entity.TotalPrice = reader.GetFieldValue<Decimal>("TotalPrice");
			entity.PaymentMethod = reader.GetFieldValue<string>("PaymentMethod");
			entity.OrderStatus = reader.GetFieldValue<string>("OrderStatus");


			//MemberTable
			entity.Account = reader.GetFieldValue<string>("Account");
			entity.FirstName = reader.GetFieldValue<string>("FirstName");
			entity.LastName = reader.GetFieldValue<string>("LastName");
			entity.Mobile = reader.GetFieldValue<string>("Mobile");
			entity.Email = reader.GetFieldValue<string>("Email");

			return entity;
		}





	}
	public class OrderStatusVm
	{
		//OrderTable
		//public int Id { get; set; }

		//public DateTime OrderDate { get; set; }

		//public decimal TotalPrice { get; set; }

		//public string PaymentMethod { get; set; }
		public string OrderStatus { get; set; }


		//public Nullable<System.DateTime> CompletionDate { get; set; }




		//MemberTable

		//public string Account { get; set; }

		//public string FirstName { get; set; }
		//public string LastName { get; set; }

		//public string Mobile { get; set; }

		//public string Email { get; set; }



		public static OrderStatusVm GetInstance(SqlDataReader reader)
		{
			var entity = new OrderStatusVm();
			//OrderTable
			//entity.Id = reader.GetFieldValue<int>("Id");
			//entity.OrderDate = reader.GetFieldValue<DateTime>("OrderDate");
			//entity.TotalPrice = reader.GetFieldValue<Decimal>("TotalPrice");
			//entity.PaymentMethod = reader.GetFieldValue<string>("PaymentMethod");
			entity.OrderStatus = reader.GetFieldValue<string>("OrderStatus");


			//MemberTable
			//entity.Account = reader.GetFieldValue<string>("Account");
			//entity.FirstName = reader.GetFieldValue<string>("FirstName");
			//entity.LastName = reader.GetFieldValue<string>("LastName");
			//entity.Mobile = reader.GetFieldValue<string>("Mobile");
			//entity.Email = reader.GetFieldValue<string>("Email");

			return entity;
		}





	}
}
