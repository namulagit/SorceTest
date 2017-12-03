using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

/// <summary>
/// Author - Swaroop
/// </summary>
namespace Sorce_smokeAutoMation.Scripts
{
    [TestClass]
    public class TC1
    {
        //IWebDriver cDriver = new ChromeDriver();
        //  IWebDriver firefoxDriver = new FirefoxDriver();

        IWebDriver firefoxDriver = new ChromeDriver();
        TimeSpan pageloadwait = TimeSpan.FromSeconds(30.00);


        [TestMethod]
        public void checkHomePageNLogin()
        {
            //LOGIN - AUTOIT USED - FIREFOX
           firefoxDriver.Navigate().GoToUrl("http://beacon-test/sorce/");
            firefoxDriver.Manage().Timeouts().ImplicitWait = pageloadwait;
            //System.Diagnostics.Process.Start("EngageLoginScreenMozilla1.exe");
            System.Diagnostics.Process.Start("EngageLoginScreenChrome2.exe");
            //ExplicitWaitClickable(firefoxDriver, "html/body/div[2]/div/div[1]/a");
            //Checking homepage Items
            //ExplicitWaitClickable(firefoxDriver, ".//*[@id=\'PI966\']");//Find Someone App Available in Homepage
            firefoxDriver.Manage().Timeouts().ImplicitWait = pageloadwait;
            string title=firefoxDriver.Title;
            Assert.AreEqual("Homepage",title,"Page Title");
        }
        [TestCleanup]
        public void Closure()
        {
            firefoxDriver.Close();
        }
       
    }
}
