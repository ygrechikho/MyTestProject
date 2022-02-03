using System;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private IDriver _driver;
        
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestInitialize()]
        public void TestInitialize()
        {
            var browserType = ConfigurationManager.AppSettings["BrowserType"];
            var url = ConfigurationManager.AppSettings["Url"];
            var cUrl = new Uri(url);
            Enum.TryParse(browserType, out IDriver.Browser cBrowserType);
            _driver.Initialize();
        }
    }
}
