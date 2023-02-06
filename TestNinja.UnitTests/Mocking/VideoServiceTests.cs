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
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnsErrorMessage()
        {
            VideoService video = new VideoService(new MockFileReader());

            string result = video.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
