using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTests
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveOrderDispalyTest()
        {
            //-- Arange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}
