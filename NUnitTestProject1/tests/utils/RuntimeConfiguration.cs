using System;

namespace NUnitTestProject1.tests.utils
{
    public class RuntimeConfiguration
    {
        private static String appSettingsFilePath = "resources/appsettings.json";
        public static String webDriverRemoteUrl { get; }

        static RuntimeConfiguration()
        {
            var configRoot = ConfigurationReader.getConfigurationRoot(appSettingsFilePath);
            webDriverRemoteUrl = configRoot["webdriver:remote"];
        }
    }
}