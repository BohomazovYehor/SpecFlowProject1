using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver("F:\\ChromeDR");
            driver.Manage().Window.Maximize();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
