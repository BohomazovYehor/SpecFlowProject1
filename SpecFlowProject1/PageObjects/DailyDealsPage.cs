using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class DailyDealsPage : BasePage
    {
        private const int DEFAULT_TIME = 60;
        
        [FindsBy(How = How.XPath, Using = "//a[text() = 'Deals']")]
        private IWebElement _dailyDealsPageLogo;
        public DailyDealsPage(IWebDriver driver) : base(driver){}
        public bool DailyDealsPageLogoVisibility()
        {
            return _dailyDealsPageLogo.Displayed;
        }
    }
}
