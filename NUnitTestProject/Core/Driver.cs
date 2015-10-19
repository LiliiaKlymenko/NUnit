using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Framework.Core
{
    class Driver
    {
        public static IWebDriver driver;

        public static void JSClick(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].click();", element);
        }

        internal static void wait()
        {
            Driver.driver.Manage().Timeouts().ImplicitlyWait(
                TimeSpan.FromSeconds(Int32.Parse(ConfigurationManager.AppSettings["Timeout"])));
        }
               
    }
}
