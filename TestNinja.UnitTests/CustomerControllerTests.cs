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
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            CustomerController controller = new CustomerController();

            ActionResult result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());

            //Checks if result is NotFound or one of it's derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            CustomerController controller = new CustomerController();

            ActionResult result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf(typeof(Ok)));
        }
    }
}
