using NUnit.Framework;

namespace Homework
{
    class Tests : Base
    {

        /// <summary>
        /// Tests login functionality with valid details and asserts that login was successful.
        /// </summary>
        [Test]
        public void Test_ValidLogin()
        {
            homePage.GoToSignInPage();
            loginPage.SignInWith(validEmail, validPassword);
            Assert.IsTrue(accountPage.GetWelcomeMessage().Text.ToLower().StartsWith("welcome to your account"));
        }

        /// <summary>
        /// Tests search functionality with valid query and asserts that all search results match the query.
        /// </summary>
        [Test]
        public void Test_Search()
        {
            homePage.SearchFor(query);
            Assert.IsTrue(searchPage.CheckQueryMatch(query));
        }

        /// <summary>
        /// Tests product purchase workflow.
        /// </summary>
        [Test]
        public void Test_Purchase()
        {
            homePage.GoToSignInPage();
            loginPage.SignInWith(validEmail, validPassword);
            accountPage.ClickLogo();
            homePage.ClickFirstProduct();
            productPage.AddToCart();
            productPage.ProceedToCheckOut();
            orderPage.ClickProceedToCheckout01();
            orderPage.ClickProceedToCheckout03();
            orderPage.AgreeWithTerms();
            orderPage.ClickProceedToCheckout04();
            orderPage.ClickPayByBankWire();
            orderPage.ClickConfirmOrder();
            Assert.IsTrue(orderPage.GetOrderCompleteMessage().Text.ToLower().StartsWith("your order on my store is complete."));
        }

    }
}
