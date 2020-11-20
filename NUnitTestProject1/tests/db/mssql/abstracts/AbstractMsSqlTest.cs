using NUnitTestProject1.tests.db.abstracts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;

namespace NUnitTestProject1.tests.mssql.abstracts
{
    public class AbstractMsSqlTest : AbstractDbTest<DbConnection>
    {
        [SetUp]
        public void setUp()
        {
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User id=root;Password=admin;");
            connection.Open();
        }
    }
}


