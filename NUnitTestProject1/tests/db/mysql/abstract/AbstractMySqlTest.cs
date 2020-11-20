using MySql.Data.MySqlClient;
using NUnit.Framework;
using NUnitTestProject1.tests.db.abstracts;
using NUnitTestProject1.tests.db.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.tests.db.mysql
{
    public class AbstractMySqlTest : AbstractDbTest<MySqlConnection>
    {
        protected MySqlUtils dbUtils;

        [SetUp]
        public void setUp()
        {
            connection = new MySqlConnection(@"server=localhost;userid=root;password=admin;database=employees");
            connection.Open();
            dbUtils = new MySqlUtils(connection);
        }
    }
}
