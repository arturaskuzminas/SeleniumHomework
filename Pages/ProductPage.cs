using OpenQA.Selenium;
using System;

namespace Homework.Pages
{
    public class ProductPage
    {
        private IWebDriver Driver { get; set; }

        public ProductPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Adds product to the cart.
        /// </summary>
        public void AddToCart()
        {
            GetAddToCartButton().Click();
        }

        /// <summary>
        /// After adding product to the cart clicks 
        /// "Proceed to checkout" in the pop-up.
        /// </summary>
        public void ProceedToCheckOut()
        {
            GetProccedToCheckoutButton().Click();
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public IWebElement GetAddToCartButton()
        {
            return Driver.FindElement(By.Id("add_to_cart"));
        }

        public IWebElement GetProccedToCheckoutButton()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return Driver.FindElement(By.CssSelector("a[title='Proceed to checkout'] > span"));
        }
    }
}
