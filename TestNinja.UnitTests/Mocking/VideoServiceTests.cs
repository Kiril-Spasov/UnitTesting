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
        private Mock<IVideoRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<FileHandler>();
            _repository = new Mock<IVideoRepository>();
            _video = new VideoService(_mock.Object, _repository.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnsErrorMessage()
        {
            _mock.Setup(fr => fr.Read("video.txt")).Returns("");

            string result = _video.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosAreProcessed_ReturnEmptyString()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());

            string result = _video.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_FewUnrpocessedVideos_ReturnStringWithIds()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>()
            {
                new Video {Id = 1},
                new Video {Id = 2},
                new Video {Id = 3},
            });

            string result = _video.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }
}
