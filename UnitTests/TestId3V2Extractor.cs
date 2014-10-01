using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DJ.Id3;

namespace UnitTests
{
    [TestClass]
    public class TestId3V2Extractor
    {
        [TestMethod]
        public void TestId3V2BasicSample()
        {
            var reader = new BinaryReader(new MemoryStream(TestResources.test_ID3v2_4));
            var id3Tag = DJ.Id3.V2Extractor.Extract(reader);
            Assert.AreEqual(id3Tag.Artist, "Test Artist");
            Assert.AreEqual(id3Tag.Album, "Test Album");
            Assert.AreEqual(id3Tag.Title, "Test Name");
        }
    }
}