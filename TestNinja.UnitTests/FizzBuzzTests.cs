using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenInputIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            string result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleBy3_ReturnsFizz()
        {
            string result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleBy5_ReturnsFizz()
        {
            string result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnsInputToString()
        {
            string result = FizzBuzz.GetOutput(4);

            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
