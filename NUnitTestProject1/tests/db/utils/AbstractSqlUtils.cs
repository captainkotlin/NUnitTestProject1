using MySql.Data.MySqlClient;
using NUnitTestProject1.tests.db.entities;
using NUnitTestProject1.tests.db.utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using NUnitTestProject1.tests.utils;

namespace NUnitTestProject1.tests.db.mssql.utils
{
    public class AbstractSqlUtils<SqlCommandType>
    {
        protected DbConnection connection;
        protected Type readerBoundary;
        public AbstractSqlUtils(DbConnection connection)
        {            
            this.connection = connection;
        }

        public List<T> read<T>(string query, Func<DbDataReader, T> mapper) where T : IReadable<T>, new()
        {
            List<T> list = new List<T>();
            
            using (var command = getSqlCommand(query))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(mapper.Invoke(reader));
                    }
                }
            }
            return list;
        }

        public Optional<T> readFirst<T>(string query, Func<DbDataReader, T> mapper) where T : IReadable<T>, new()
        {
            using (var command = getSqlCommand(query))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return Optional<T>.of(mapper.Invoke(reader));
                    }
                }
            }
            return null;
        }

        private DbCommand getSqlCommand(String query)
        {
            return (DbCommand) Activator.CreateInstance(typeof(SqlCommandType), query, connection);
        }
    }
}
