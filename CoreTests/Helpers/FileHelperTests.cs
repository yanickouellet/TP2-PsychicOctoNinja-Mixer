using System;
using System.IO;
using DJ.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DJ.CoreTests.Helpers
{
    [TestClass]
    public class FileHelperTests
    {
        [TestMethod]
        public void CreateMusicItem_ShouldCorrectlyReadInformationsFromFile()
        {
            var item = FileHelper.CreateMusicItem(new FileInfo(@"../../Resources/dragonborn.mp3"));

            Assert.AreEqual("Dragonborn", item.Name);
            Assert.AreEqual("Skyrim", item.Artist);
            Assert.AreEqual("1:34", item.Time);
        }
    }
}
