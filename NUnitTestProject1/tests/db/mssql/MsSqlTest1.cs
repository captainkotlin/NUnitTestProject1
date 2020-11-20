using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnitTestProject1.tests.db.mssql.entities;
using NUnitTestProject1.tests.mssql.abstracts;
using NUnitTestProject1.tests.mssql.utils;

namespace NUnitTestProject1.tests.db.mssql
{
    [TestFixture]
    public class MsSqlTest1 : AbstractMsSqlTest
    {
        [Test]
        public void test()
        {
            List<Customer> customers = new MsSqlUtils(connection).read("SELECT * FROM Northwind.dbo.Customers", new Customer().read);
            Console.WriteLine("Omg");
        }
    }
}
