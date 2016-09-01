using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ebay.PO.Pages;
using Epam.JDI.Core.Settings;
using JDI_Web.Selenium.DriverFactory;
using JDI_Web.Selenium.Elements.Composite;
using JDI_Web.Settings;
using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static JDI_Web.Settings.WebSettings;
using Timer = JDI_Commons.Timer;

namespace Ebay.test
{
    [TestFixture]
    class Test
    {
        private IWebDriver driver;
        [Test]
        public void Test1()
        {
            EbaySite.homePage.searchInput.Input("book");
       
            EbaySite.homePage.submit.Click();
           
        //    EbaySite.homePage.buyNow.Click();

            Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
            Debug.WriteLine(EbaySite.homePage.pageViewType.GetText);
            if (!EbaySite.homePage.pageViewType.GetText.Contains("В виде галереи"))
                EbaySite.homePage.pageViewType.Select("В виде галереи");


            /*         EbaySite.homePage.SelectView("В виде галереи");

            EbaySite.homePage.GetSearchResultList()[0].Click();
            EbaySite.itemPreviewPage.addToCart.Click();

            Assert.True(1 == EbaySite.cartPage.GetCartItemsCount());*/

        }

     //   [Test]
        public void test2()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ebay.com");
            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            //driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));

            driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("shoes");
            driver.FindElement(By.Id("gh-btn")).Click();
            driver.FindElement(By.Id("gh-btn")).Click();
            driver.FindElements(By.XPath("//*[@id='GalleryViewInner']/li"))[0].Click();
            //driver.FindElement(By.XPath("//*[@id='GalleryViewInner']/li[1]")).Click();

        }

        [SetUp]
        public void setup()
        {
            Timer _timer = new Timer();

            WebSettings.InitNUnitDefault();
            WinProcUtils.KillAllRunWebDrivers();

            if (!JDISettings.DriverFactory.HasDrivers())
                WebSettings.UseDriver(DriverTypes.Chrome);
            _timer = new Timer();

            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            WebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));

            WebSite.Init(typeof(EbaySite));
            EbaySite.homePage.Open();
        }




        [TearDown]
        public void Teardown()
        {
           // Thread.Sleep(30000);

            WebDriver.Quit();
        }
    }
}
