using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    internal class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_fileDownloader.Object);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            _fileDownloader.Setup(f => f.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

            bool result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {
            bool result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
