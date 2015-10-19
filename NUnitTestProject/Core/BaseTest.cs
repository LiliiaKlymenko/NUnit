using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Framework.Core
{
    [TestFixture]
    public class BaseTest
    {
        [TestFixtureSetUp]
        public void Init()        
        {
            Driver.driver = new FirefoxDriver(); 
            Driver.driver.Manage().Timeouts().ImplicitlyWait(
                TimeSpan.FromSeconds(Int32.Parse(ConfigurationManager.AppSettings["Timeout"])));
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseURL"]);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }
}
