using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Base;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Complex;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium;

namespace Ebay.PO.Pages
{
    public class CartPage : WebPage
    {

        [FindBy(Css = "#PageTitle > h1")] public Text pageTitle;

      
        public int GetCartItemsCount()
        {
            return WebDriver.FindElements(By.XPath(@"//*[contains(@class, 'c-std')]
                                                /div[@id[starts-with(.,'sellerBucket')]]")).Count;
        }
    }
}
