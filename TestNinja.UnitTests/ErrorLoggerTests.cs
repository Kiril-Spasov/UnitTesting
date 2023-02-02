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
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetsLastErrorPropertyToMethodInput()
        {
            _logger.Log("test error");

            Assert.That(_logger.LastError, Is.EqualTo("test error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenInputIsNullOrWhiteSpace_ThrowsArgumentNullException(string input)
        {
            Assert.That(() => _logger.Log(input), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            Guid id = Guid.Empty;

            _logger.ErrorLogged += (sender, args) => { id = args; };

            _logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        }
    }
}
