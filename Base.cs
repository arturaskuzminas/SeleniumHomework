using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Homework
{
    public class Base
    {

        private readonly string _Path = @"C:\Users\.Net\chromedriver";
        protected IWebDriver Driver;
        //------------------------------------------------------------
        // Test data
        protected string validEmail = "praktika@email.com";
        protected string validPassword = "testas";
        protected string query = "blouse";
        //------------------------------------------------------------
        // POM Objects
        protected HomePage homePage;
        protected LoginPage loginPage;
        protected AccountPage accountPage;
        protected ProductPage productPage;
        protected SearchPage searchPage;
        protected OrderPage orderPage;

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver(_Path);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com");

            homePage = new HomePage(Driver);
            loginPage = new LoginPage(Driver);
            accountPage = new AccountPage(Driver);
            productPage = new ProductPage(Driver);
            searchPage = new SearchPage(Driver);
            orderPage = new OrderPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }

    }
}
