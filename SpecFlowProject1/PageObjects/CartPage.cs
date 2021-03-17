using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SpecFlowProject1.PageObjects
{
    class CartPage : BasePage
    {
        private const int DEFAULT_TIME = 60;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'grid__group details')]")]
        private IWebElement _itemInCart;
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'call')]")]
        private IWebElement _goToCheckoutButton;
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'btn--secondary')]")]
        private IWebElement _continueAsGuestButton;

        public CartPage(IWebDriver driver) : base(driver) { }
        public bool ItemInCartVisibility()
        {
            return _itemInCart.Displayed;
        }
        public void ClickGoToCheckOutButton()
        {
            WaitClickableElement(DEFAULT_TIME, _goToCheckoutButton);

            _goToCheckoutButton.Click();
        }
        public void ClickContinueAsGuestButton()
        {
            WaitClickableElement(DEFAULT_TIME, _continueAsGuestButton);
            _continueAsGuestButton.Click();
        }
    }
}
