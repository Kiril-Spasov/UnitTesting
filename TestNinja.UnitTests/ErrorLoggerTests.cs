using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetsLastErrorPropertyToMethodInput()
        {
            ErrorLogger logger = new ErrorLogger();
            logger.Log("test error");

            Assert.That(logger.LastError, Is.EqualTo("test error"));
        }
    }
}
