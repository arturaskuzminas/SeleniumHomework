using OpenQA.Selenium;

namespace Homework
{
    public class AccountPage
    {
        private IWebDriver Driver { get; set; }

        public AccountPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Clicks page logo which redirects to the homepage.
        /// </summary>
        public void ClickLogo()
        {
            GetLogo().Click();
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public IWebElement GetWelcomeMessage()
        {
            return Driver.FindElement(By.ClassName("info-account")); 
        }

        public IWebElement GetLogo()
        {
            return Driver.FindElement(By.Id("header_logo"));
        }
    }
}
