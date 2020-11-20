using NUnitTestProject1.tests.db.entities;
using NUnitTestProject1.tests.db.mssql.utils;
using NUnitTestProject1.tests.db.utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace NUnitTestProject1.tests.mssql.utils
{
    public class MsSqlUtils : AbstractSqlUtils<SqlCommand>
    {
        public MsSqlUtils(DbConnection connection) : base(connection)
        {
                   
        }

        //public List<T> read<T>(string query, Func<SqlDataReader, T> mapper) where T : IReadable<T>, new()
        //{
        //    List<T> list = new List<T>();
        //    using (var command = new SqlCommand(query, connection))
        //    {
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                list.Add(mapper.Invoke(reader));
        //            }
        //        }
        //    }
        //    return list;
        //}

        //public Optional<T> readFirst<T>(string query, Func<SqlDataReader, T> mapper) where T : IReadable<T>, new()
        //{
        //    using (var command = new SqlCommand(query, connection))
        //    {
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                return Optional<T>.of(mapper.Invoke(reader));
        //            }
        //        }
        //    }
        //    return null;
        //}

    }

}
