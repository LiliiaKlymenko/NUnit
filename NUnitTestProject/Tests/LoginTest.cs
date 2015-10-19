using NUnit.Framework;
using Framework.Core;
using Task7.UI.Login;
using Task7.UI.Deals;

namespace Task7.Tests
{ 
    [TestFixture]
    class YaSearch : BaseTest
    {
        [SetUp]
        public void Precondition()
        {
            Logger.Info("Prepare test script");
        }
              
        [Test]
        public void TestLogin() 
        {
            string titleUsername = "DefaultAdmin";
            Logger.Info("Test Login started");
            LoginPage loginPage = LoginPage.Open();
            MainPage mainPage = loginPage.LoginAsAdmin();
            string actualUsername = mainPage.getTitleUsername();
            Assert.AreEqual(actualUsername, titleUsername, "Assert that user is currently logged in as " + titleUsername);
          
        }

        [TearDown]
        public void Cleanup()
        {
            Logger.Info("Test Cleanup");
        }
    }
}
