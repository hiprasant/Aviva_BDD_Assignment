using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Assignment.Framework
{
    public class MyDriver
    {
        public static IWebDriver driver;

        public static void BrowserSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
