using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class StackTests
    {
        private Fundamentals.Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Fundamentals.Stack<string>();
        }

        [Test]
        public void Push_WhenInputIsNull_ThrowsArgumentNullException()
        {
            Fundamentals.Stack<string> test = new Fundamentals.Stack<string>();

            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenInputIsValidObject_AddsItemItemOnTopOfTheStack()
        {
            _stack.Push("abc");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_WhenStackIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenStackIsNotEmpty_ReturnsItemOnTopOfTheStack()
        {
            _stack.Push("a");
            _stack.Push("b");

            string result = _stack.Pop();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Pop_WhenStackIsNotEmpty_RemovesItemOnTopOfTheStack()
        {
            _stack.Push("a");
            _stack.Push("b");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_WhenStackIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenStackIsNotEmpty_ReturnsItemOnTopOfTheStack()
        {
            _stack.Push("abc");

            object result = _stack.Peek();

            Assert.That(result, Is.EqualTo("abc"));
        }

        [Test]
        public void Peek_WhenStackIsNotEmpty_DoesNotRemoveTheItemOnTopOfTheStack()
        {
            _stack.Push("abc");

            object result = _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(1));
        }


    }
}
