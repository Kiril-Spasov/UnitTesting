using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_WhenIdIsZero_ReturnsNotFound()
        {
            CustomerController controller = new CustomerController();

            ActionResult result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf(typeof(NotFound)));
        }

        [Test]
        public void GetCustomer_WhenIdIsNotZero_ReturnsOk()
        {
            CustomerController controller = new CustomerController();

            ActionResult result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf(typeof(Ok)));
        }
    }
}
