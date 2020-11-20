using MySql.Data.MySqlClient;
using NUnitTestProject1.tests.db.mssql.utils;
using System.Data.Common;


namespace NUnitTestProject1.tests.db.utils
{
    public class MySqlUtils : AbstractSqlUtils<MySqlCommand>
    {
        public MySqlUtils(DbConnection connection) : base(connection)
        {
            
        }
    }
}
