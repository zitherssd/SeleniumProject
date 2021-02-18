using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class CfrRouteTest : BaseTest
    {
        private string departure = "Sinaia";
        private string destination = "Deva";

        [Test]
        public void RouteTest()
        {
            CfrHomePage cfrHomePage = new CfrHomePage(driver);
            cfrHomePage.GoTo();
            cfrHomePage.ClosePopup();
            cfrHomePage.SearchRoutes(departure,destination);

            SearchResultPage searchPage = new SearchResultPage(driver);

            Assert.IsTrue(searchPage.CheckTitle(departure,destination));
        }
    }
}
