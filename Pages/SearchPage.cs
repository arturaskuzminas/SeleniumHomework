using OpenQA.Selenium;

namespace Homework.Pages
{
    public class SearchPage
    {
        private IWebDriver Driver { get; set; }

        public SearchPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        /// <summary>
        /// Checks whether results after search match the search query.
        /// If all results (products titles) contains search query then returns true.
        /// Note! Products on the left side of the page are not taken into consideration.
        /// </summary>
        /// <param name="searchQuery"> text to search for </param>
        /// <returns> true | false </returns>
        public bool CheckQueryMatch(string searchQuery)
        {
            var match = false;
            var itemNames = Driver.FindElements(getItemContainer());

            foreach (IWebElement element in itemNames)
            {
                // match = true as long as element in cycle contains search query text
                if (element.Text.ToLower().Contains(searchQuery.ToLower()))
                {
                    match = true;
                }
                // if at least one element does not contain search query text then
                // search is considered as working incorrectly
                else
                {
                    match = false;
                    break;
                }
            }
            return match;
        }

        //-------------------------------------
        /*              SELECTORS            */
        //-------------------------------------

        public By getItemContainer()
        {
            return By.ClassName("product-container");
        }
    }
}
