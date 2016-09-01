using System;
using Ebay.PO.Pages;
using Epam.JDI.Core.Settings;
using JDI_Commons;
using JDI_Web.Selenium.DriverFactory;
using JDI_Web.Selenium.Elements.Composite;
using JDI_Web.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static JDI_Web.Settings.WebSettings;


namespace Ebay.steps
{
    [Binding]
    public class BaseStep
    {
        [BeforeFeature()]
        public static void Setup()
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
        }

        [AfterFeature()]
        public static void Teardown()
        {
            WebDriver.Quit();
        }
    }
}