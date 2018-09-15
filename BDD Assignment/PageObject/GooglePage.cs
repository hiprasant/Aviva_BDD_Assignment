using BDD_Assignment.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Assignment.PageObject
{
    public class GooglePage
    {
        public IWebElement SearchField
        {
            get
            {
                return MyDriver.driver.FindElement(By.Name("q"));
            }
        }

        public IList<IWebElement> LinksList
        {
            get
            {
                return MyDriver.driver.FindElements(By.XPath("//div[@class='rc']/h3[@class='r']/a"));
            }
        }

        public void Search(String text)
        {
            this.SearchField.SendKeys(text);
            this.SearchField.Submit();
        }
    }
}


