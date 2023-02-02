using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class MathTests
    {

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            //Arrange
            Fundamentals.Math math = new Fundamentals.Math();

            //Act
            int result = math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            //Arrange
            Fundamentals.Math math = new Fundamentals.Math();

            //Act
            int result = math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //Arrange
            Fundamentals.Math math = new Fundamentals.Math();

            //Act
            int result = math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            //Arrange
            Fundamentals.Math math = new Fundamentals.Math();

            //Act
            int result = math.Max(2, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
