using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ebay.PO.Sections;
using Epam.JDI.Core.Interfaces.Complex;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Complex;
using JDI_Web.Selenium.Elements.Composite;
using NUnit.Framework;
using OpenQA.Selenium;
using JDI_Web.Attributes.Objects;

namespace Ebay.PO.Pages
{
    public class HomePage: WebPage
    {
        [FindBy(ClassName = "ui-autocomplete-input")]
        public TextField searchInput;

        [FindBy(Id = "gh-btn")]
        public Button submit;

        [FindBy(XPath = "//*[@id='GalleryViewInner']/li")]
        public Elements<Text> searchElements = new Elements<Text>(By.XPath("//*[@id='GalleryViewInner']/li"));

        [FindBy(XPath = "//*[@id='Brand']/../../div[contains(@class,'pnl-b')]//span[contains(text(),'adidas')]")]
        public Link adidasBrand;

        [FindBy(XPath = "(//a[contains(@href,'BIN')])[1]")]
        public Link buyNow;

        public IDropDown pageViewType = new Dropdown(By.Id("viewType"), By.XPath("*root*//*[@id='ViewTypeMenu']//span"));


        public void SelectView(string viewName)
        {
            WebDriver.FindElement(By.Id("viewType")).Click();
            WebDriver.FindElement(By.XPath($"//*[@id='ViewTypeMenu']//*[contains(text(), '{viewName}')]")).Click();
        }

        public void InsureGaleryView()
        {

        }

        public List<IWebElement> GetSearchResultList()
        {
            List<IWebElement> res =
                new List<IWebElement>(WebDriver.FindElements(By.XPath("//*[@id='GalleryViewInner']/li")));
            return res;
        }
        
      
    }
}
