using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Ebay.PO.Pages
{
    public class ItemPreviewPage: WebPage
    {
        [FindBy(Id = "isCartBtn_btn")] public Button addToCart;
    }
}
