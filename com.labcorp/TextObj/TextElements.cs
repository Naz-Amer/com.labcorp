using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace com.labcorp.TextObj
{
    class TextElements
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//h1[normalize-space()='Laboratory Automation Engineer']")]
        public IWebElement JobTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='job-location job-info']")]
        public IWebElement JobLocation { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[@class='job-id job-info']")]
        public IWebElement JobId { get; set; }

        [FindsBy(How = How.XPath, Using = " //h3[normalize-space()='Jobs Near You']")]
        public IWebElement JobsNear{ get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[normalize-space()='COVID-19 UPDATE']")]
        public IWebElement CovidText { get; set; }

        [FindsBy(How = How.XPath,Using = "//h2[normalize-space()='Explore More']")]
        public  IWebElement MoreEX { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='button job-apply top']")]
        public IWebElement applyButton { get; set; }

        [FindsBy(How = How.XPath, Using = " //span[@class='jobTitle job-detail-title']")]
        public IWebElement  JobTiElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='jobnum']")]
        public IWebElement jobID { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='resultfootervalue']")]
        public IWebElement jobLocation { get; set; }


        [FindsBy(How = How.XPath, Using = " //span[normalize-space()='Return to Job Search']")]
        public IWebElement returnButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='×']")]
        public IWebElement PopUP { get; set; }

        






    }
}
