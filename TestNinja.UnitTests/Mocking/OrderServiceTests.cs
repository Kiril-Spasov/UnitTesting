using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    internal class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            Mock<IStorage> mock = new Mock<IStorage>();
            OrderService service = new OrderService(mock.Object);
            Order order = new Order();

            service.PlaceOrder(order);

            mock.Verify(s => s.Store(order));
        }
    }
}
