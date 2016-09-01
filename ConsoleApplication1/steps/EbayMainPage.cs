using System;
using System.Collections.Generic;
using Ebay.PO.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static Ebay.PO.Pages.EbaySite;
using static JDI_Web.Settings.WebSettings;

namespace Ebay.steps
{
    [Binding]
    public class EbayMainPage : BaseStep
    {
        [Given(@"I search for '(.*)'")]
        public void GivenISearchFor(string p0)
        {
            EbaySite.homePage.searchInput.Input(p0);
            EbaySite.homePage.submit.Click();
        }

        [Given(@"select (.*) item in search result")]
        public void GivenSelectItemInSearchResult(int p0)
        {

            EbaySite.homePage.GetSearchResultList()[p0].Click();
        }

        [Given(@"add the item to cartPage")]
        public void GivenAddTheItemToCart()
        {
            EbaySite.itemPreviewPage.addToCart.Click();
        }

        [When(@"I click add to cart button")]
        public void WhenIClickAddToCartButton()
        {
            EbaySite.itemPreviewPage.addToCart.Click();
        }

        [Given(@"select adidas brands")]
        public void GivenSelectAdidasBrands()
        {
            EbaySite.homePage.adidasBrand.Click();
        }

        [Given(@"click buy now link")]
        public void GivenClickBuyNowLink()
        {
            EbaySite.homePage.buyNow.Click();
        }

        [Given(@"And Select '(.*)'")]
        public void GivenAndSelect(string p0)
        {
            EbaySite.homePage.pageViewType.Select(p0);
        }

        [Then(@"verify I am on cart page")]
        public void ThenVerifyIAmOnCartPage()
        {
            Assert.That("Ваша корзина".Equals(EbaySite.cartPage.pageTitle.GetText), message: EbaySite.cartPage.pageTitle.GetText);
            Assert.That(WebDriver.Url.Contains("cart.payments.ebay.com"), message: WebDriver.Url);
        }

        [Then(@"verify number of items in cart is (.*)")]
        public void ThenVerifyNumberOfItemsInCartIs(int p0)
        {
            Assert.True(p0 == EbaySite.cartPage.GetCartItemsCount());
        }

        [Given(@"I go to main page")]
        public void GivenIGoToMainPage()
        {
            EbaySite.homePage.Open();
        }

        [Given(@"insure '(.*)' view")]
        public void GivenInsureView(string p0)
        {
           // EbaySite.homePage.pageViewType.Ge("В виде галереи")
        }
    }
}
