using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebay.PO.Pages;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Complex;
using JDI_Web.Selenium.Elements.Composite;

namespace Ebay.PO.Pages
{
    [Site(Domain = "http://www.ebay.com")]
    public class EbaySite
    {
        [Page]
        public static HomePage homePage;

        [Page]
        public static ItemPreviewPage itemPreviewPage;

        [Page]
        public static CartPage cartPage;
    }
}
