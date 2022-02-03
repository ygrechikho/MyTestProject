using System;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools.V85.Browser;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        IDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestInitialize()]
        public void TestInitialize()
        {
            _driver = new DriverAdapter();
            _driver.Initialize();
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            _driver.Close();
        }
    }
}
