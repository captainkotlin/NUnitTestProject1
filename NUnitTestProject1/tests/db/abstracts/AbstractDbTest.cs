using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using NUnit.Framework;

namespace NUnitTestProject1.tests.db.abstracts
{
    public class AbstractDbTest<T> where T : DbConnection
    {
        protected T connection;

        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("!Connection closed");
            connection.Close();
        }
    }
}
