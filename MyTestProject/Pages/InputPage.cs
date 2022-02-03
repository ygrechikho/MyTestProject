using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MyTestProject
{
    class InputPage
    {
        private readonly IWebDriver _driver;
        public readonly Uri AbsolutePath = new Uri("https://letcode.in/edit");
    }
}
