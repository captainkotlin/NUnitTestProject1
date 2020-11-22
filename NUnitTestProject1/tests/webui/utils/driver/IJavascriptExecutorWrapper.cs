using OpenQA.Selenium;

namespace NUnitTestProject1.tests.webui.utils
{
    public class IJavascriptExecutorWrapper : IJavaScriptExecutor
    {
        private IJavaScriptExecutor javaScriptExecutor;

        public IJavascriptExecutorWrapper(IJavaScriptExecutor javaScriptExecutor)
        {
            this.javaScriptExecutor = javaScriptExecutor;
        }

        public object ExecuteScript(string script, params object[] args)
        {
            return javaScriptExecutor.ExecuteScript(script, args);
        }

        public object ExecuteAsyncScript(string script, params object[] args)
        {
            return javaScriptExecutor.ExecuteAsyncScript(script, args);
        }

        public static IJavascriptExecutorWrapper of(IJavaScriptExecutor javaScriptExecutor)
        {
            return new IJavascriptExecutorWrapper(javaScriptExecutor);
        }
        
        public T ExecuteScript<T>(string script, params object[] args)
        {
            return (T) javaScriptExecutor.ExecuteScript(script, args);
        }
    }
}