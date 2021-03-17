using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class SignInPage : BasePage
    {
        private const int DEFAULT_TIME = 60;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'userid')]")]
        private IWebElement _emailField;
        [FindsBy(How = How.XPath, Using = "//button[contains(@id, 'signin-continue-btn')]")]
        private IWebElement _continueSignInButton;
        [FindsBy(How = How.XPath, Using = "//span/p")]
        private IWebElement _errorMassage;
        [FindsBy(How = How.XPath, Using = "//input[@id = 'pass']")]
        private IWebElement _passwordField;
        [FindsBy(How = How.XPath, Using = "//button[@id = 'sgnBt']")]
        private IWebElement _signInButton;
        public SignInPage(IWebDriver driver) : base(driver){}

        public void InputEmailInEmailField(string email) {
            _emailField.SendKeys(email);
        }
        public void ClickContinueSignInButton() {
            WaitClickableElement(DEFAULT_TIME, _continueSignInButton);
            _continueSignInButton.Click();
        }
        public bool ErrorMassaageVisibility() {
            WaitVisibilityOfElement(DEFAULT_TIME, By.XPath("//span/p"));
            return _errorMassage.Displayed;
        } 
        public void InputIncorrectPasswordInPasswordField(string password)
        {
            WaitVisibilityOfElement(DEFAULT_TIME, By.XPath("//input[@id = 'pass']"));
            _passwordField.SendKeys(password);
        }
        public void ClickSignInButton() {
            WaitClickableElement(DEFAULT_TIME, _signInButton);
            _signInButton.Click();
        }
    }
}
