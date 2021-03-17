using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class SearchResutsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'srp-save-search_')]")]
        private IWebElement _popUpMassage;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'info clear')]/a[contains(@href, '124628199558')]")]
        private IWebElement _searchItem;
        public SearchResutsPage(IWebDriver driver) : base(driver){}

        public bool SearchItemVisibility() {
            return _searchItem.Displayed;
        }

        public void ClickSearchItem() {
            _searchItem.Click();
        }

        public void ClosePopUpMassage() {
            if (_popUpMassage.Displayed)
            {
                _popUpMassage.Click();
            }
        }
    }
}
