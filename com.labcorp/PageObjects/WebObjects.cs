using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace com.labcorp.PageObjects
{
    class WebObjects
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath,Using = "//nav[@class='column labcorp']//li[3]//a[1]")]
        public IWebElement Career { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='search-keyword']")]
        public IWebElement KeywordSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='search-location']")]
        public IWebElement CityStateZip { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Submit']")]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.XPath, Using = " //h2[normalize-space()='Laboratory Automation Engineer']")]
        public IWebElement firstone { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='button job-apply top']")]
        public IWebElement applayNow { get; set; }



    }
}
