using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace NUnitTestProject1.tests.utils
{
    public class ConfigurationReader
    {
        public static IConfigurationRoot getConfigurationRoot(String filePath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(filePath, optional: true, reloadOnChange: true)
                .Build();
        }
    }
}