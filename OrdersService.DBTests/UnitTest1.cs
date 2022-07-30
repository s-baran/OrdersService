using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdersService.DB;
using System;

namespace OrdersService.DBTests
{
    [TestClass]
    public class DatabaseTests
    {
        private Database dbContext;

        [TestInitialize]
        public void Initialize()
        {
            dbContext = new Database();
        }
        [TestMethod]
        public void GetOrderDetailsTest()
        {
            var result = dbContext.GetOrderDetails(2);
            Assert.IsNotNull(result);
        }
    }
}
