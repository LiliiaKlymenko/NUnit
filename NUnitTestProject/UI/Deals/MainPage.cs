using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Task7.UI.Deals
{
    class MainPage
    {
        [FindsBy(How = How.XPath, Using = ".//li[@id='username']/a")]
        public IWebElement titleUsername;

        public MainPage()
        {
            Driver.driver.SwitchTo().DefaultContent();
            PageFactory.InitElements(Driver.driver, this);
        }

        public string getTitleUsername()
        {
            return titleUsername.Text; 
        }
               
    }
}
