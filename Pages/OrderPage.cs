using OpenQA.Selenium;

namespace Homework.Pages
{
    public class OrderPage
    {
        private IWebDriver Driver { get; set; }

        public OrderPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Clicks 'Proceed to checkout' button in the first step of checkout process.
        /// </summary>
        public void ClickProceedToCheckout01()
        {
            GetProceedButton01().Click();
        }

        /// <summary>
        /// Clicks 'Proceed to checkout' button in the third step of checkout process.
        /// </summary>
        public void ClickProceedToCheckout03()
        {
            GetProceedButtont03().Click();
        }

        /// <summary>
        /// Clicks 'Proceed to checkout' button in the fourth step of checkout process.
        /// </summary>
        public void ClickProceedToCheckout04()
        {
            GetProceedButton04().Click();
        }

        /// <summary>
        /// Checks 'Agree with terms' checkbox in the fourth step of checkout process.
        /// </summary>
        public void AgreeWithTerms()
        {
            GetAgreeTermsCheckBox().Click();
        }

        /// <summary>
        /// Clicks 'Pay by bank wire' link in the fifth step of checkout process.
        /// </summary>
        public void ClickPayByBankWire()
        {
            GetPayByBankWireLink().Click();
        }

        /// <summary>
        /// Clicks 'I confirm my order' button in the fifth step of checkout process.
        /// </summary>
        public void ClickConfirmOrder()
        {
            GetConfirmOrderButton().Click();
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public IWebElement GetProceedButton01()
        {
            return Driver.FindElement(By.CssSelector("div#center_column  a[title='Proceed to checkout'] > span")); 
        }

        public IWebElement GetProceedButtont03()
        {
            return Driver.FindElement(By.CssSelector("div#center_column > form[method='post']  button > span"));
        }

        public IWebElement GetProceedButton04()
        {
            return Driver.FindElement(By.CssSelector("form#form  button > span"));
        }

        public IWebElement GetAgreeTermsCheckBox()
        {
            return Driver.FindElement(By.Id("cgv"));
        }

        public IWebElement GetPayByBankWireLink()
        {
            return Driver.FindElement(By.CssSelector("a[title='Pay by bank wire'] > span"));
        }

        public IWebElement GetConfirmOrderButton()
        {
            return Driver.FindElement(By.CssSelector("p#cart_navigation  span"));
        }

        public IWebElement GetOrderCompleteMessage()
        {
            return Driver.FindElement(By.CssSelector("div#center_column .dark"));
        }
    }
}
