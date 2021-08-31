using System;
using com.labcorp.PageObjects;
using com.labcorp.TextObj;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Mapping;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;


namespace com.labcorp.StepDefinitions
{
    [Binding]
    public class LabcorpLoginPageSteps
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void RunBeforeScenario()
        {

            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

            [Given(@"As a user I should naviagte to labcorp webpage")]
        public void GivenAsAUserIShouldNaviagteToLabcorpWebpage()
        {
            driver.Navigate().GoToUrl("https://www.labcorp.com/");
        }
        
        [Given(@"As a user I should find and click careers link")]
        public void GivenAsAUserIShouldFindAndClickCareersLink()
        {
            var webPages = new WebObjects();
            PageFactory.InitElements(driver,webPages);
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", webPages.Career);
            webPages.Career.Click();
        }
        
        [Then(@"As a user I should search for active position")]
        public void ThenAsAUserIShouldSearchForActivePosition()
        {
            
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            var webPages = new WebObjects();
            PageFactory.InitElements(driver, webPages);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", webPages.KeywordSearch);
            webPages.KeywordSearch.SendKeys("Laboratory Automation Engineer 1");
            webPages.CityStateZip.Clear();
            webPages.submitButton.Click();
            js.ExecuteScript("arguments[0].scrollIntoView();", webPages.firstone);
            webPages.firstone.Click();
            js.ExecuteScript("arguments[0].scrollIntoView();", webPages.applayNow);

        }

        [Then(@"Add assertions con confirm Job Title,Job Location, JobId")]
        public void ThenAddAssertionsConConfirmJobTitleJobLocationJobId()
        {

            var textelements = new TextElements();
            PageFactory.InitElements(driver, textelements);

            Assert.AreEqual("Laboratory Automation Engineer", textelements.JobTitle.Text);
            //Assert.AreEqual("Location South San Francisco, California", textelements.JobLocation.Text);
            Assert.AreEqual("Job ID 21-89455", textelements.JobId.Text);
          


        }
        
        [Then(@"And (.*) other assertion of the choice")]
        public void ThenAndOtherAssertionOfTheChoice(int p0)
        {
            var textelements = new TextElements();
            PageFactory.InitElements(driver, textelements);
            Assert.AreEqual("Jobs Near You", textelements.JobsNear.Text);
            Assert.AreEqual("COVID-19 UPDATE", textelements.CovidText.Text);
            Assert.AreEqual("Explore More", textelements.MoreEX.Text);

            
        }
        
        [Then(@"Clcik Applay Now button and confirm Job Title,Job Location, JobId on the proceeding page")]
        public void ThenClcikApplayNowButtonAndConfirmJobTitleJobLocationJobIdOnTheProceedingPage()
        {
            var textelements = new TextElements();
            PageFactory.InitElements(driver, textelements);
            textelements.applyButton.Click();
            
            var isElementDisplayed = textelements.JobTiElement.Displayed;
            var isElementDisplayed2 = textelements.jobLocation.Displayed;
            var isElementDisplayed3 = textelements.jobID.Displayed;


        }
        
        [Then(@"Click to Return to Job Search")]
        public void ThenClickToReturnToJobSearch()
        {
            var textelements = new TextElements();
            PageFactory.InitElements(driver, textelements);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement click = wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='×']")));
            textelements.PopUP.Click();
            PageFactory.InitElements(driver, textelements);
            textelements.returnButton.Click();

        }

        [AfterScenario]

        public void RunAfterScenario()
        {
            driver.Quit();
        }

    }


}
