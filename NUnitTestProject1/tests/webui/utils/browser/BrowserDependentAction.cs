using System;
using System.Collections.Generic;

namespace NUnitTestProject1.tests.webui.utils
{
    public class BrowserDependentAction<T>
    {
        private Dictionary<String, Func<T>> dict = new Dictionary<string, Func<T>>();

        public BrowserDependentAction<T> with(String browser, Func<T> func)
        {
            dict[browser] = func;
            return this;
        }

        public T get(String browser)
        {
            var func = dict[browser];
            return (T) func.Invoke();
        }
    }
}