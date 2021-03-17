using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.PageObjects;
using System;

namespace SpecFlowProject1
{
    class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void WaitForPageLoadComplete(int timeToWait)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(timeToWait)).Until(
                    _driver => (IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete");
        }

        public void WaitClickableElement(int timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public void WaitVisibilityOfElement(int timeToWait, By element)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
        public HomePage GetHomePage()
        {
            return new HomePage(_driver);
        }
        public CartPage GetCartPage() {
            return new CartPage(_driver);
        }
        public DailyDealsPage GetDailyDealsPage() {
            return new DailyDealsPage(_driver);
        }
        public HelpPage GetHelpPage()
        {
            return new HelpPage(_driver);
        }
        public ItemPage GetItemPage()
        {
            return new ItemPage(_driver);
        }
        public PaymentPage GetPaymentPage()
        {
            return new PaymentPage(_driver);
        }
        public SearchResutsPage GetSearchResutsPage()
        {
            return new SearchResutsPage(_driver);
        }
        public SignInPage GetSignInPage()
        {
            return new SignInPage(_driver);
        }
        public SporingGoodsPage GetSporingGoodsPage()
        {
            return new SporingGoodsPage(_driver);
        }
        public TennisPage GetTennisPage()
        {
            return new TennisPage(_driver);
        }
    }
}
