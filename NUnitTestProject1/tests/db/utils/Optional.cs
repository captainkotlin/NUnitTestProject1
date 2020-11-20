using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.tests.db.utils
{
    public class Optional<T>
    {
        private T val { get; }

        public Optional(T val)
        {
            this.val = val;
        }

        public static Optional<T> of(T val)
        {
            return new Optional<T>(val);
        }

        public static Optional<T> empty()
        {
            return new Optional<T>(default(T));
        }

        public bool isPresent(Object o)
        {
            return val != null;
        }
    }
}
