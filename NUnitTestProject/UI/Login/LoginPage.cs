using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task7.UI.Deals;
using System.Configuration;
using Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Task7.UI.Login
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "loginUsername")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "loginSubmit")]
        public IWebElement loginButton;

        static string  baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        static string  defAdminUsername = ConfigurationManager.AppSettings["AdminUsername"];
        static string defAdminPass = ConfigurationManager.AppSettings["AdminPassword"];

        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public MainPage LoginAsAdmin()
        {   
            username.SendKeys(defAdminUsername);
            password.SendKeys(defAdminPass);
            loginButton.Click();            
            return new MainPage();
           
        }

        public static LoginPage Open()
        {
            Driver.driver.Navigate().GoToUrl(baseUrl);
            return new LoginPage();
        }
    }
}
