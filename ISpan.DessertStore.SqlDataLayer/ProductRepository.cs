using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class ProductRepository
	{
		private readonly string _tableName = "Products";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, ProductIndexVm> funcAssemblerVm = ProductIndexVm.GetInstance;
		public Func<SqlDataReader, ProductUpdateEntity> funcAssembler = ProductUpdateEntity.GetInstance;
		public IEnumerable<ProductIndexVm> Search(string productName,string categoryName)
		{
			#region 生成SQL 陳述式
			string sql = $@"SELECT *
FROM {_tableName} as p
INNER JOIN Categories as c
ON p.CategoryID = c.ID ";
			//p.Id,p.ProductName ,c.Name AS CategoryName,Picture1,p.UnitPrice,p.Description,
			//p.UnitsInStock,p.ProductStatus,p.ProductUnit
			#endregion
			#region 生成where子句
			string where = string.Empty;
			var parameters = new List<SqlParameter>();//SQL參數
			if (string.IsNullOrEmpty(productName) == false)
			{
				where += $" AND p.ProductName LIKE+ '%' + @productName +'%' ";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@productName", System.Data.SqlDbType.NVarChar, 50) { Value = productName });
			}
			if (string.IsNullOrEmpty(categoryName) == false)
			{
				where += $" AND c.Name LIKE+ '%' + @categoryName +'%' ";
				//where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@categoryName", System.Data.SqlDbType.NVarChar, 50) { Value = categoryName });
			}
			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;
			sql += $" ORDER BY(p.ID);";
			#endregion
			return SqlDb.Search(funcConn, funcAssemblerVm, sql, parameters.ToArray());
		}
		public int Create(ProductIndexVm entity)
		{
			string sql = $@"INSERT INTO {_tableName}
(SellerID,ProductName,CategoryID,ProductStatus,ProductFlavor,ProductSize,ProductUnit,UnitsInStock,UnitPrice,Description,Picture1)
VALUES
(@SellerID,@ProductName,@CategoryID,@ProductStatus,@ProductFlavor,@ProductSize,@ProductUnit,@UnitsInStock,@UnitPrice,@Description,@Picture1)";


			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", entity.Id)
				.AddInt("SellerID",entity.SellerID)
				.AddNVarchar("ProductName", entity.ProductName, 50)
				.AddInt("CategoryID", entity.CategoryID)
				.AddBool("ProductStatus",entity.ProductStatus)
				.AddNVarchar("ProductFlavor",entity.ProductFlavor,50)
				.AddNVarchar("ProductSize", entity.ProductSize, 50)
				.AddNVarchar("ProductUnit", entity.ProductUnit, 50)
				.AddInt("UnitsInStock", entity.UnitsInStock)
				.AddDecimal("UnitPrice", entity.UnitPrice)
				.AddNVarchar("Description", entity.Description, 500)
				.AddNVarchar("Picture1", entity.Picture1, 500)
				.Build();
			
			int productName = 0;
			try
			{
				productName = SqlDb.Create(funcConn, sql, parameters);

			}
			catch (SqlException ex)
			{
				if (ex.Message.Contains("IX_Users"))
				{
					//throw new Exception("您新增的帳號已存在, 請修改之後再試一次", ex);
				}
			}
			return productName;
		}
		public int Update(ProductUpdateEntity entity)
		{
			var sql = $@"UPDATE {_tableName}
SET CategoryID=@CategoryID ,ProductName = @ProductName,ProductStatus=@ProductStatus,
Picture1=@Picture1,ProductUnit = @ProductUnit,ProductFlavor = @ProductFlavor, ProductSize= @ProductSize,
Description=@Description,UnitsInStock=@UnitsInStock,UnitPrice=@UnitPrice
WHERE  ID = {entity.Id};";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("SellerID", entity.SellerID)
				.AddNVarchar("ProductName", entity.ProductName, 50)
				.AddInt("CategoryID", entity.CategoryID)
				.AddBool("ProductStatus", entity.ProductStatus)
				.AddNVarchar("ProductFlavor", entity.ProductFlavor, 50)
				.AddNVarchar("ProductSize", entity.ProductSize, 50)
				.AddNVarchar("ProductUnit", entity.ProductUnit, 50)
				.AddInt("UnitsInStock", entity.UnitsInStock)
				.AddDecimal("UnitPrice", entity.UnitPrice)
				.AddNVarchar("Description", entity.Description, 500)
				.AddNVarchar("Picture1", entity.Picture1, 500)
				.Build();

			int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql, parameters);
			return rowsAffected;
		}

		public int Delete(int productId)
		{
			//var sql = $"DELETE FROM {_tableName} WHERE Id={userId}";
			//int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
			//return rowsAffected;

			var sql = $"DELETE FROM {_tableName} WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", productId)
				.Build();

			return SqlDb.UpdateOrDelete(funcConn, sql, parameters);
		}
		public ProductIndexVm GetProductVm(int productId)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Id={productId}";

			return SqlDb.Get(funcConn, funcAssemblerVm, sql);
		}
		public ProductUpdateEntity GetProduct(int productId)
		{
			string sql = $"SELECT * FROM {_tableName} WHERE Id={productId}";

			return SqlDb.Get(funcConn, funcAssembler, sql);
		}
	}

	public class ProductIndexVm
	{

		public int Id { get; set; }
		public int CategoryID { get; set; }
		public int SellerID { get; set; }
		
		public string ProductName { get; set; }
		public string CategoryName { get; set; }
		public bool ProductStatus { get; set; }
		public string ProductUnit { get; set; }
		public string Picture1 { get; set; }

		public string ProductFlavor { get; set; }
		public string ProductSize { get; set; }
		public Decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public string Description { get; set; }
		
		

		public int UnitsOnOrder { get; set; }

		public DateTime? UploadDate { get; set; }
		public DateTime? LastModified { get; set; }


		public static ProductIndexVm GetInstance(SqlDataReader reader)
		{
			var entity = new ProductIndexVm();
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.CategoryID = reader.GetFieldValue<int>("CategoryID");
			//entity.SellerID = reader.GetFieldValue<int>("SellerID");
			entity.CategoryName = reader.GetFieldValue<string>("Name");
			entity.ProductName = reader.GetFieldValue<string>("ProductName");
			entity.ProductStatus = reader.GetFieldValue<bool>("ProductStatus");

			entity.ProductUnit = reader.GetFieldValue<string>("ProductUnit");
			entity.Picture1 = reader.GetFieldValue<string>("Picture1");
			//entity.ProductFlavor = reader.GetFieldValue<string>("ProductFlavor");
			//entity.ProductSize = reader.GetFieldValue<string>("ProductSize");
			entity.Description = reader.GetFieldValue<string>("Description");

			entity.UnitsInStock = reader.GetFieldValue<int>("UnitsInStock");
			entity.UnitPrice = reader.GetFieldValue<Decimal>("UnitPrice");
			//entity.UnitsOnOrder = reader.GetFieldValue<int>("UnitsOnOrder");
			//entity.UploadDate = reader.GetFieldValue<DateTime>("UploadDate");
			//entity.LastModified = reader.GetFieldValue<DateTime>("LastModified");
			return entity;
		}

	}
	public class ProductUpdateEntity
	{

		public int Id { get; set; }
		public int CategoryID { get; set; }
		public int SellerID { get; set; }

		//public int ProductID { get; set; }

		public string ProductName { get; set; }
		//public string CategoryName { get; set; }
		public bool ProductStatus { get; set; }
		public string ProductUnit { get; set; }
		public string Picture1 { get; set; }

		public string ProductFlavor { get; set; }
		public string ProductSize { get; set; }
		public Decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public string Description { get; set; }



		//public int UnitsOnOrder { get; set; }

		//public DateTime? UploadDate { get; set; }
		//public DateTime? LastModified { get; set; }


		public static ProductUpdateEntity GetInstance(SqlDataReader reader)
		{
			var entity = new ProductUpdateEntity();
			entity.Id = reader.GetFieldValue<int>("Id");
			entity.CategoryID = reader.GetFieldValue<int>("CategoryID");
			entity.SellerID = reader.GetFieldValue<int>("SellerID");
			//entity.CategoryName = reader.GetFieldValue<string>("Name");
			//entity.ProductID = reader.GetFieldValue<string>("ProductID");
			entity.ProductName = reader.GetFieldValue<string>("ProductName");
			entity.ProductStatus = reader.GetFieldValue<bool>("ProductStatus");

			entity.ProductUnit = reader.GetFieldValue<string>("ProductUnit");
			entity.Picture1 = reader.GetFieldValue<string>("Picture1");
			entity.ProductFlavor = reader.GetFieldValue<string>("ProductFlavor");
			entity.ProductSize = reader.GetFieldValue<string>("ProductSize");
			entity.Description = reader.GetFieldValue<string>("Description");

			entity.UnitsInStock = reader.GetFieldValue<int>("UnitsInStock");
			entity.UnitPrice = reader.GetFieldValue<Decimal>("UnitPrice");
			//entity.UnitsOnOrder = reader.GetFieldValue<int>("UnitsOnOrder");
			//entity.UploadDate = reader.GetFieldValue<DateTime>("UploadDate");
			//entity.LastModified = reader.GetFieldValue<DateTime>("LastModified");
			return entity;
		}

	}
}
