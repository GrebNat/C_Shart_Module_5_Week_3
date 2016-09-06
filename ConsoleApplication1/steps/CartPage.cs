using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebay.PO.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static JDI_Web.Settings.WebSettings;

namespace Ebay.steps
{
    [Binding]
    class CartPage : BaseStep
    {
        [Then(@"verify I am on cart page")]
        public void ThenVerifyIAmOnCartPage()
        {
            Assert.That("Ваша корзина".Equals(EbaySite.cartPage.pageTitle.GetText), message: EbaySite.cartPage.pageTitle.GetText);
            Assert.That(WebDriver.Url.Contains("cart.payments.ebay.com"), message: WebDriver.Url);
        }

        [Then(@"verify number of items in cart more then (.*)")]
        public void ThenVerifyNumberOfItemsInCartIs(int p0)
        {
            Assert.True(p0 <= EbaySite.cartPage.GetCartItemsCount());
        }
    }
}
