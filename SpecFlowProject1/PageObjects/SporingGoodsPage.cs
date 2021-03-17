using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class SporingGoodsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'b-visualnav__grid')]//a[contains(@href, '1865461')]")]
        private IWebElement _tennisButton;
        [FindsBy(How = How.XPath, Using = "//section[contains(@id, 's0-15-6-0-1[1]-0')]")]
        private IWebElement _sportingGoodsLogo;
        
        public SporingGoodsPage(IWebDriver driver) : base(driver){}

        public void ClickTennisButton() {
            _tennisButton.Click();
        }
        public bool SportingGoodsLogoVisibility() {
            return _sportingGoodsLogo.Displayed;
        }
    }
}
