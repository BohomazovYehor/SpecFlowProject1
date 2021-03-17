using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class TennisPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'b-pageheader__text')]")]
        private IWebElement _tennisPageLogo;
        
        public TennisPage(IWebDriver driver) : base(driver){}

        public bool TennisPageLogoVisibility() {
            return _tennisPageLogo.Displayed;
        }
    }
}
