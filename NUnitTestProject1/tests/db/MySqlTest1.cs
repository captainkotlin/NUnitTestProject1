using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using NUnit.Framework;
using MySql.Data.MySqlClient;
using NUnitTestProject1.tests.db.mysql;
using NUnitTestProject1.tests.db.utils;
using NUnitTestProject1.tests.db.mysql.entities;
using NUnitTestProject1.tests.utils;

namespace NUnitTestProject1.tests.db
{
    [TestFixture]
    public class MySqlTest1 : AbstractMySqlTest
    {
        [Test]
        [Category(TestCategories.MySql)]
        public void test()
        {
            Console.WriteLine("Test");
            List<Dept> deps = dbUtils.read("SELECT * FROM departments WHERE dept_name LIKE '%c%'", new Dept().read);
            Optional<Dept> f = dbUtils.readFirst("SELECT * FROM departments WHERE dept_name LIKE '%c%'", new Dept().read);
        }
    }
}
