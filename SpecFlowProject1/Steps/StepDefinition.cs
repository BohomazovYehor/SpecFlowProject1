using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class SmokeSteps
    {
        private const int DEFAULT_TIME = 60;
        public IWebDriver driver = WebHook.driver;
        HomePage homePage;
        SearchResutsPage searchResutsPage;
        CartPage cartPage;
        DailyDealsPage dailyDealsPage;
        HelpPage helpPage;
        ItemPage itemPage;
        PaymentPage paymentPage;
        SignInPage signInPage;
        SporingGoodsPage sporingGoodsPage;
        TennisPage tennisPage;
        BasePage basePage;     

        [Given(@"User opens '(string)' page")]
        public void GivenUserOpensPage(string url)
        {
            basePage = new BasePage(driver);
            homePage = basePage.GetHomePage();
            homePage.OpenHomePage(url);
        }
        
        [Given(@"User checks search field visibility")]
        public void GivenUserChecksSearchFieldVisibility()
        {
            homePage.WaitForPageLoadComplete(DEFAULT_TIME);
            homePage.SearchFieldVisibility();
        }
        
        [When(@"User makes search by keyword '(.*)'")]
        public void WhenUserMakesSearchByKeyword(string keyword)
        {
            homePage.InputSearchItemNameInSearchField(keyword);
        }
        
        [When(@"User clicks search button")]
        public void WhenUserClicksSearchButton()
        {
            homePage.ClickSearchButton();
        }
        
        [Then(@"User checks visibility of searching item")]
        public void ThenUserChecksVisibilityOfSearchingItem()
        {
            searchResutsPage = basePage.GetSearchResutsPage();
            searchResutsPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(searchResutsPage.SearchItemVisibility());
        }
        [When(@"User clicks searching item link")]
        public void WhenUserClicksSearchingItemLink()
        {
            searchResutsPage = basePage.GetSearchResutsPage();
            searchResutsPage.WaitForPageLoadComplete(DEFAULT_TIME);
            searchResutsPage.ClosePopUpMassage();
            searchResutsPage.ClickSearchItem();
        }

        [When(@"User clicks add to cart button")]
        public void WhenUserClicksAddToCartButton()
        {
            itemPage = basePage.GetItemPage();
            itemPage.AddToCartButtonVisibility();
            itemPage.ClickAddToCartButton();
        }

        [Then(@"User checks item visibility in cart")]
        public void ThenUserChecksItemVisibilityInCart()
        {
            cartPage = basePage.GetCartPage();
            cartPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(cartPage.ItemInCartVisibility());
        }
        [When(@"User click go to checkout")]
        public void WhenUserClickGoToCheckout()
        {
            cartPage = basePage.GetCartPage();
            cartPage.ClickGoToCheckOutButton();
            cartPage.ClickContinueAsGuestButton();
        }

        [Then(@"user checks visibility of payment fields")]
        public void ThenUserChecksVisibilityOfPaymentFields()
        {
            paymentPage = basePage.GetPaymentPage();
            paymentPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(paymentPage.CheckoutLogoVisibility());
        }
        [Given(@"User click sign in button")]
        public void GivenUserClickSignInButton()
        {
            homePage.ClickSignInButton();
        }

        [When(@"User enter unregister email '(.*)'")]
        public void WhenUserEnterUnregisterEmail(string email)
        {
            signInPage = basePage.GetSignInPage();
            signInPage.WaitForPageLoadComplete(DEFAULT_TIME);
            signInPage.InputEmailInEmailField(email);
        }

        [When(@"User click continue button")]
        public void WhenUserClickContinueButton()
        {
            signInPage.ClickContinueSignInButton();
        }

        [Then(@"User checks visibility of error massage")]
        public void ThenUserChecksVisibilityOfErrorMassage()
        {
            Assert.IsTrue(signInPage.ErrorMassaageVisibility());
        }
        [When(@"User click category button")]
        public void WhenUserClickCategoryButton()
        {
            homePage.ClickCategoryButton();
        }

        [Then(@"User check visibility of category popup")]
        public void ThenUserCheckVisibilityOfCategoryPopup()
        {
            Assert.IsTrue(homePage.CategoryPopUpVisibility());
        }
        [When(@"User click help button")]
        public void WhenUserClickHelpButton()
        {
            homePage.ClickHelpButton();
        }

        [Then(@"User checks visibility of input field")]
        public void ThenUserChecksVisibilityOfInputField()
        {
            helpPage = basePage.GetHelpPage();
            helpPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(helpPage.InputHelpFieldVisibility());
        }
        [When(@"User click sporting goods button")]
        public void WhenUserClickSportingGoodsButton()
        {
            homePage.ClickSportsGoodsButton();
        }

        [When(@"User click tennis goods button")]
        public void WhenUserClickTennisGoodsButton()
        {
            sporingGoodsPage = basePage.GetSporingGoodsPage();
            sporingGoodsPage.WaitForPageLoadComplete(DEFAULT_TIME);
            sporingGoodsPage.ClickTennisButton();
        }

        [Then(@"User check tennis page is displayed")]
        public void ThenUserCheckTennisPageIsDisplayed()
        {
            tennisPage = basePage.GetTennisPage();
            tennisPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(tennisPage.TennisPageLogoVisibility());
        }
        [Then(@"User checks sporting goods page is displayed")]
        public void ThenUserChecksSportingGoodsPageIsDisplayed()
        {
            sporingGoodsPage = basePage.GetSporingGoodsPage();
            sporingGoodsPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(sporingGoodsPage.SportingGoodsLogoVisibility());
        }
        [When(@"User enter register email '(.*)'")]
        public void WhenUserEnterRegisterEmail(string email)
        {
            signInPage = basePage.GetSignInPage();
            signInPage.WaitForPageLoadComplete(DEFAULT_TIME);
            signInPage.InputEmailInEmailField(email);
        }

        [When(@"User enter incorrect password '(.*)'")]
        public void WhenUserEnterIncorrectPassword(string password)
        {
            signInPage.InputIncorrectPasswordInPasswordField(password);
        }

        [When(@"User click sign in button on sign in page")]
        public void WhenUserClickSignInButtonOnSignInPage()
        {
            signInPage.ClickSignInButton();
        }
        [When(@"User click daily deals button")]
        public void WhenUserClickDailyDealsButton()
        {
            homePage.ClickDailyDealsButton();
        }

        [Then(@"User checks daily deals page is load")]
        public void ThenUserChecksDailyDealsPageIsLoad()
        {
            dailyDealsPage = basePage.GetDailyDealsPage();
            dailyDealsPage.WaitForPageLoadComplete(DEFAULT_TIME);
            Assert.IsTrue(dailyDealsPage.DailyDealsPageLogoVisibility());
        }      
    }
}
