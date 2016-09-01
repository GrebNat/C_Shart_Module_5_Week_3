using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Ebay.PO.Sections
{
    public class SearchResultItem : Section
    {
        [FindBy(Css = "img.img")]
        public Image itemImage;

        [FindBy(Css = ".amt > span")]
        public Text price;
    }
}
