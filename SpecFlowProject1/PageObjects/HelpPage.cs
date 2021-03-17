using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class HelpPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'search_input_element')]")]
        private IWebElement _inputHelpField;
        public HelpPage(IWebDriver driver) : base(driver){}

        public bool InputHelpFieldVisibility()
        {
            return _inputHelpField.Displayed;
        }
    }
}
