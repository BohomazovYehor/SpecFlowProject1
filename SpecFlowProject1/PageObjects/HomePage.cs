using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowProject1.PageObjects
{
    class HomePage : BasePage
    {
    [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder, 'Search')]")]
    private IWebElement _searchField;

    [FindsBy(How = How.XPath, Using = "//input[contains(@value, 'Search')]")]
    private IWebElement _searchButton;

    [FindsBy(How = How.XPath, Using = "//a[text() = 'Sign in']")]
    private IWebElement _signInButton;

    [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'gh-sbc-o')]")]
    private IWebElement _categoryPopUp;

    [FindsBy(How = How.XPath, Using = "//button[contains(@id, 'gh-shop-a')]")]
    private IWebElement _categoryButton;

    [FindsBy(How = How.XPath, Using = "//a[text() = ' Help & Contact']")]
    private IWebElement _helpButton;

    [FindsBy(How = How.XPath, Using = "//a[contains(@href, '186503')]")]
    private IWebElement _sportsGoodsButton;

    [FindsBy(How = How.XPath, Using = "//a[text() = ' Daily Deals']")]
    private IWebElement _dailyDealsButton;
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public void OpenHomePage(string url)
        {
            _driver.Url = url;
        }
        public bool SearchFieldVisibility()
        {
            return _searchField.Displayed;
        }
        public void InputSearchItemNameInSearchField(string itemName)
        {
            _searchField.SendKeys(itemName);
        }

        public void ClickSearchButton()
        {
            _searchButton.Click();
        }

        public void ClickSignInButton() { _signInButton.Click(); }

        public void ClickCategoryButton() { _categoryButton.Click(); }

        public bool CategoryPopUpVisibility() { return _categoryPopUp.Displayed; }

        public void ClickHelpButton() { _helpButton.Click(); }

        public void ClickSportsGoodsButton() { _sportsGoodsButton.Click(); }

        public void ClickDailyDealsButton() { _dailyDealsButton.Click(); }
    }
}
