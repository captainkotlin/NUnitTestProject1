using NUnitTestProject1.tests.db.entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace NUnitTestProject1.tests.db.mssql.entities
{
    public class Customer : IReadable<Customer>
    {
        private String customerID { get; set; }
        private String companyName { get; set; }
        private String contactName { get; set; }
        private String contactTitle { get; set; }

        public override Customer read(DbDataReader reader)
        {
            customerID = reader["customerID"].ToString();
            contactName = reader["companyName"].ToString();
            companyName = reader["contactName"].ToString();
            contactTitle = reader["contactTitle"].ToString();
            return this;
        }
    }
}
