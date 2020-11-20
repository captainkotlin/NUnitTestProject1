using NUnitTestProject1.tests.db.entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace NUnitTestProject1.tests.db.mysql.entities
{
    class Dept : IReadable<Dept>
    {
        private String deptNo { get; set; }
        private String deptName { get; set; }

        public override Dept read(DbDataReader reader)
        {
            deptNo = reader["dept_no"].ToString();
            deptName = reader["dept_name"].ToString();
            return this;
        }
    }
}
