using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyTestProject
{
    public class DriverAdapter : IDriver
    {
        public IWebDriver _driver;

        public DriverAdapter(IWebDriver driver)
        {
            Console.WriteLine(" *** Portal launched");
            _driver = driver;
        }

        private void CreateDriver(IDriver.Browser browserType)
        {
            switch (browserType)
            {
                case IDriver.Browser.Chrome:
                {
                    var chromeOptions = LoadChromeOptions();
                    _driver = LoadChromeWebDriver(chromeOptions);
                    break;
                }
            }
        }

        private IWebDriver LoadChromeWebDriver(ChromeOptions chromeOptions)
        {
            var chromeDriver = new ChromeDriver(chromeOptions);
            return chromeDriver;
        }

        public ChromeOptions LoadChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-extensions");

            return options;
        }

        public void SetBrowserUri(Uri url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Initialize()
        {
            var browserType = ConfigurationManager.AppSettings["BrowserType"];
            var url = ConfigurationManager.AppSettings["Url"];
            var cUrl = new Uri(url);
            Enum.TryParse(browserType, out IDriver.Browser cBrowserType);
            Launch(cBrowserType, cUrl);
        }
        public void Launch(IDriver.Browser browserType, Uri url )
        {
            CreateDriver(browserType);
            SetBrowserUri(url);
        }

        public void Close()
        {
            if (_driver == null) return;
            _driver.Quit();
        }
    }
}
