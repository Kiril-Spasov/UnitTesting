using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithBoldElement()
        {
            //Arrange
            HtmlFormatter formatter = new HtmlFormatter();

            //Act
            string result = formatter.FormatAsBold("abc");

            //Assert
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
        }
    }
}
