using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.DessertStore.SqlDataLayer
{
	
	public class CategoryRepository
	{
		private static List<CategoryEntity> CategoryItems { get; set; }

		private readonly string _tableName = "Categories";
		public Func<SqlConnection> funcConn = SqlDb.GetConnection;
		public Func<SqlDataReader, CategoryEntity> funcAssembler = CategoryEntity.GetInstance;
		public CategoryEntity GetCategory(int categoryId)
		{
			CategoryEntity category = null;
			using (var conn = SqlDb.GetConnection())
			{
				string sql = $"SELECT * FROM Categories WHERE Id={categoryId}";
				using (var command = new SqlCommand(sql, conn))
				{
					conn.Open();

					var reader = command.ExecuteReader();

					if (reader.Read())
					{
						return CategoryEntity.GetInstance(reader);
						//category = new Category
						//{
						//    Id = categoryId,
						//    Name = reader.GetFieldValue<string>("Name"),
						//    DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
						//};
					}
				}
			}
			return category;
		}

		/// <summary>
		/// 查詢該筆類別ID的方法
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns></returns>
		public int GetProductCount(int categoryId)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string sql = $"SELECT Count(*) FROM Products WHERE CategoryId={categoryId}";
				using (var command = new SqlCommand(sql, conn))
				{
					conn.Open();

					object result = command.ExecuteScalar();
					return Convert.ToInt32(result);
				}
			}
		}

		public IEnumerable<CategoryEntity> Search(string name, string displayorder)
		{
			#region 生成 sql statement
			string sql = $@"SELECT *
FROM {_tableName}";

			#region 生成where子句
			string where = string.Empty;

			var parameters = new List<SqlParameter>();

			if (string.IsNullOrEmpty(name) == false)
			{
				where += $" AND Name LIKE '%' + @Name + '%'";
				parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 50) { Value = name });
			}
			if (string.IsNullOrEmpty(displayorder) == false)
			{
				where += $" AND DisplayOrder= @DisplayOrder";
				parameters.Add(new SqlParameter("@DisplayOrder", System.Data.SqlDbType.NVarChar, 50) { Value = displayorder });
			}


			where = where == string.Empty ? where : where = " WHERE " + where.Substring(5);
			sql += where;

			#endregion
			#endregion
			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
		public int Create(CategoryEntity entity)
		{
			string sql = $@"INSERT INTO {_tableName}
(Name,DisplayOrder)
VALUES
(@Name,@DisplayOrder)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", entity.Name, 50)
				.AddInt("DisplayOrder", entity.DisplayOrder)
				.Build();

			int cateoryId = 0;
			try
			{
				cateoryId = SqlDb.Create(funcConn, sql, parameters);

			}
			catch (SqlException ex)
			{
				if (ex.Message.Contains("IX_Users"))
				{
					//throw new Exception("您新增的帳號已存在, 請修改之後再試一次", ex);
				}
			}
			return cateoryId;
		}

		public int Update(CategoryEntity entity)
		{   // 在此, 並不更新CreatedTime
			string sql = @"UPDATE Categories SET
Name =@Name,
DisplayOrder =@DisplayOrder
WHERE
	Id=@Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNVarchar("@Name", entity.Name, 50)
				.AddInt("@DisplayOrder", entity.DisplayOrder)
				.AddInt("@Id", entity.Id)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
		public int Delete(int userId)
		{
			//var sql = $"DELETE FROM {_tableName} WHERE Id={userId}";
			//int rowsAffected = SqlDb.UpdateOrDelete(funcConn, sql);
			//return rowsAffected;

			var sql = $"DELETE FROM {_tableName} WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("Id", userId)
				.Build();

			return SqlDb.UpdateOrDelete(funcConn, sql, parameters);
		}
		public IEnumerable<CategoryEntity> GetAll() 
		{

			string sql = $@"SELECT *
FROM {_tableName}";

			var parameters = new List<SqlParameter>();

			return SqlDb.Search(funcConn, funcAssembler, sql, parameters.ToArray());
		}
	}
	

	/// <summary>
	/// 類別中有用到的欄位
	/// </summary>
	public class CategoryEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }

		public static CategoryEntity GetInstance(SqlDataReader reader)
		{
			return new CategoryEntity
			{
				Id = reader.GetFieldValue<int>("Id"),
				Name = reader.GetFieldValue<string>("Name"),
				DisplayOrder = reader.GetFieldValue<int>("DisplayOrder")
			};
		}
		
	}

	//SqlDataReader的擴充方法，可以從reader回傳的資料中，讀取對應欄位名的值
	//public static class SqlDataReaderExtensions
	//{
	//	public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
	//		=> source[columnName].Equals(DBNull.Value)
	//			? default(T)
	//			: (T)source[columnName];

	//}
}
