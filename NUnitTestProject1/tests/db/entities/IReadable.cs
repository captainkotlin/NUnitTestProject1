using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace NUnitTestProject1.tests.db.entities
{
    public abstract class IReadable<T> where T : new()
    {
        public abstract T read(DbDataReader reader);
    }
}
