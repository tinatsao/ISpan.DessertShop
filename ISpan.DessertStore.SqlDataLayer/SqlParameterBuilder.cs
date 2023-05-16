﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters;

		public SqlParameterBuilder()
		{
			_parameters = new List<SqlParameter>();
		}

		public static SqlParameterBuilder Create() => new SqlParameterBuilder();

		public SqlParameter[] Build()
		{
			return _parameters.ToArray();
		}

		public SqlParameterBuilder AddNVarchar(string name, string value, int length)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, System.Data.SqlDbType.NVarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, System.Data.SqlDbType.NVarChar, length) { Value = value };

			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBuilder AddDateTime(string name, DateTime? value)
		{
			var parameter = value.HasValue
				? new SqlParameter(name, System.Data.SqlDbType.DateTime) { Value = value }
				: new SqlParameter(name, System.Data.SqlDbType.DateTime) { Value = DBNull.Value };

			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBuilder AddInt(string name, int? value, ParameterDirection direction = ParameterDirection.Input)
		{
			var parameter = value.HasValue
				? new SqlParameter(name, System.Data.SqlDbType.Int) { Value = value, Direction = direction }
				: new SqlParameter(name, System.Data.SqlDbType.Int) { Value = DBNull.Value, Direction = direction };

			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddBool(string name, bool? value)
		{
			var parameter = value.HasValue
				? new SqlParameter(name, System.Data.SqlDbType.Bit) { Value = value }
				: new SqlParameter(name, System.Data.SqlDbType.Bit) { Value = DBNull.Value };

			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBuilder AddDecimal(string name, decimal? value)
		{
			var parameter = value.HasValue
				? new SqlParameter(name, System.Data.SqlDbType.Decimal) { Value = value }
				: new SqlParameter(name, System.Data.SqlDbType.Decimal) { Value = DBNull.Value };

			_parameters.Add(parameter);

			return this;
		}
        public SqlParameterBuilder AddByte(string name, byte[] value)
        {
            var parameter = (value == null || value.Length == 0)
                ? new SqlParameter(name, System.Data.SqlDbType.Image) { Value = DBNull.Value }
                : new SqlParameter(name, System.Data.SqlDbType.Image) { Value = value };

            _parameters.Add(parameter);

            return this;
        }
    }
}
