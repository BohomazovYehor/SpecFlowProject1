using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class PaymentPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Checkout']")]
        private IWebElement _checkoutLogo;
        public PaymentPage(IWebDriver driver) : base(driver){}

        public bool CheckoutLogoVisibility() {
            return _checkoutLogo.Displayed;
        }
    }
}
