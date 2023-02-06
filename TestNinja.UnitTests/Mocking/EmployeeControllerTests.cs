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
    internal class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteEmployeeFromDb()
        {
            Mock<IEmployeeStorage> storage = new Mock<IEmployeeStorage>();

            EmployeeController controller = new EmployeeController(storage.Object);

            controller.DeleteEmployee(1);

            storage.Verify(s => s.DeleteEmployee(1));
        }
    }
}
