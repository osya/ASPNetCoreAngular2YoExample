using ASPNetCoreAngular2YoExample.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPNetCoreAngular2YoExampleTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly HomeController _homeController;

        public UnitTest1() => _homeController = new HomeController();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _homeController.Index();
            Assert.IsNotNull(result);
        }
    }
}
