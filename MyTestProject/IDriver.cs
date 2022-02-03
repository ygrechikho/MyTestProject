using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MyTestProject
{
    public interface IDriver
    {
        public enum Browser { Default = 0, Chrome = 1, Firefox = 2 }

        void Initialize();
        void Close();
    }
}
