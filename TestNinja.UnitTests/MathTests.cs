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
        Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            //Act
            int result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            //Act
            int result = _math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //Act
            int result = _math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {
            //Act
            int result = _math.Max(2, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
