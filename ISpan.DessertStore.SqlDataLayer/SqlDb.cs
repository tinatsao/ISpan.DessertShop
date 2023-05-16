using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.IO;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class SqlDb
	{
		public static string ApplicationName { get; set; }
		public static int ConnectTimeout { get; set; } // def=0
		public static bool? Pooling { get; set; }

		/// <summary>
		/// 取得連線字串
		/// </summary>
		/// <param name="keyOfConnString"></param>
		/// <returns></returns>
		public static string GetConnectionString(string keyOfConnString)
		{
			var node = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString];

			if (node == null) throw new Exception($"找不到節點{keyOfConnString} , 請確認後再次一次");

			string connStr = node.ToString();

			var sb = new SqlConnectionStringBuilder(connStr);
			if (string.IsNullOrEmpty(ApplicationName) == false) sb.ApplicationName = ApplicationName;
			if (ConnectTimeout > 0) sb.ConnectTimeout = ConnectTimeout; // 預設是15秒
			if (Pooling.HasValue) sb.Pooling = Pooling.Value; // 預設是true,表示要不要使用連線池

			return sb.ToString();
		}
		public static SqlConnection GetConnection() { return GetConnection("default"); }

		public static SqlConnection GetConnection(string keyOfConnString)
		{
			string connStr = GetConnectionString(keyOfConnString);
			return new SqlConnection(connStr); // 建立一個SqlConnection 物件並傳回
		}

		public static int UpdateOrDelete(Func<SqlConnection> funcConnection, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConnection())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery(); // 傳回被異動的筆數
				}
			}
		}

		public static int Create(Func<SqlConnection> funcConnection, string sql, params SqlParameter[] parameters)
		{
			sql += ";SELECT SCOPE_IDENTITY();";

			using (var conn = funcConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = sql;
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		public static T Get<T>(Func<SqlConnection> funcConnection, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConnection())
			{
				using (var cmd = new SqlCommand(sql, conn))
				{
					conn.Open();

					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					return reader.Read()
					? funcAssembler(reader)
					: default(T);
				}

			}
		}

		public static IEnumerable<T> Search<T>(Func<SqlConnection> funcConnection, Func<SqlDataReader, T> funcAssembler,
												string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = sql;
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						yield return funcAssembler(reader);
					}
				}
			}

		}
		/// <summary>
		/// 轉圖片用
		/// </summary>
		/// <param name="image"></param>
		/// <returns></returns>
		public static byte[] ImageToBytes(System.Drawing.Image image)
		{
			if (image == null) { return null; }

			else
			{
				ImageFormat format = image.RawFormat;
				using (MemoryStream ms = new MemoryStream())
				{
					if (format.Equals(ImageFormat.Jpeg))
					{
						image.Save(ms, ImageFormat.Jpeg);
					}
					else if (format.Equals(ImageFormat.Png))
					{
						image.Save(ms, ImageFormat.Png);
					}
					else if (format.Equals(ImageFormat.Bmp))
					{
						image.Save(ms, ImageFormat.Bmp);
					}
					else if (format.Equals(ImageFormat.Gif))
					{
						image.Save(ms, ImageFormat.Gif);
					}
					else if (format.Equals(ImageFormat.Icon))
					{
						image.Save(ms, ImageFormat.Icon);
					}
					byte[] buffer = new byte[ms.Length];
					ms.Seek(0, SeekOrigin.Begin);
					ms.Read(buffer, 0, buffer.Length);
					return buffer;
				}
			}
		}

	}
	/// <summary>
	/// 暫時，不確定可以。
	/// </summary>
	public static class SqlDataReaderExtensions
	{
		//用欄位名取得資料的 SqlDataReader擴充功能
		public static T GetFieldValue<T>(this SqlDataReader source, string columnName)
			=> source[columnName].Equals(DBNull.Value)
				? default(T)
				: (T)source[columnName];

	}
}
