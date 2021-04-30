using OpenQA.Selenium;

namespace Homework
{
    public class LoginPage
    {
        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Sets given email and password and clicks "Sign in" button".
        /// </summary>
        /// <param name="email"> email value </param>
        /// <param name="password"> password value </param>
        public void SignInWith(string email, string password)
        {
            getEmailField().SendKeys(email);
            getPasswordField().SendKeys(password);
            getLoginButton().Click();
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public IWebElement getEmailField()
        {
            return Driver.FindElement(By.Id("email"));
        }

        public IWebElement getPasswordField()
        {
            return Driver.FindElement(By.Id("passwd"));
        }

        public IWebElement getLoginButton()
        {
            return Driver.FindElement(By.Id("SubmitLogin"));
        }
    }
}
