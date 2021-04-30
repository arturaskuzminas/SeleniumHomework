using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Homework
{
    public class HomePage
    {
        private IWebDriver Driver { get; set; }

        public HomePage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Clicks navbar item "Sign in"
        /// </summary>
        public void GoToSignInPage()
        {
            getNavItemSignIn().Click();
        }

        /// <summary>
        /// Searches for an item in the store.
        /// </summary>
        /// <param name="query"> query text </param>
        public void SearchFor(string query)
        {
            getSearchField().SendKeys(query);
            getSearchButton().Click();
        }

        /// <summary>
        /// Clicks the first product in the homepage.
        /// </summary>
        public void ClickFirstProduct()
        {
            Actions action = new Actions(Driver);
            var collection = Driver.FindElements(By.ClassName("product-container"));
            action.MoveToElement(collection[0]).Perform();
            collection[0].Click();
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public IWebElement getSearchField()
        {
            return Driver.FindElement(By.Id("search_query_top"));
        }

        public IWebElement getSearchButton()
        {
            return Driver.FindElement(By.Name("submit_search"));
        }

        public IWebElement getNavItemSignIn()
        {
            return Driver.FindElement(By.CssSelector("a[title='Log in to your customer account']"));
        }

        public IWebElement getProductContainer()
        {
            return Driver.FindElement(By.ClassName("product-container"));
        }
    }
}
