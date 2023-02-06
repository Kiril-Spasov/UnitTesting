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
    internal class VideoServiceTests
    {
        private Mock<FileHandler> _mock;
        private VideoService _video;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<FileHandler>();
            _video = new VideoService(_mock.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnsErrorMessage()
        {
            _mock.Setup(fr => fr.Read("video.txt")).Returns("");

            string result = _video.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
