using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class ItemPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@id, 'isCartBtn_btn')]")]
        private IWebElement _addToCartButton;
        public ItemPage(IWebDriver driver) : base(driver){}

        public bool AddToCartButtonVisibility() {
            return _addToCartButton.Displayed;
        }

        public void ClickAddToCartButton()
        {
            _addToCartButton.Click();
        }
    }
}
