using System.IO;
using DJ.Core.Audio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DJ.CoreTests.Audio
{
    [TestClass]
    public class PlaylistTests
    {
        private Playlist _playlist;

        [TestInitialize]
        public void Setup()
        {
            _playlist = new Playlist();
        }

        [TestMethod]
        public void Constructor_ShouldBuildEmptyPlaylist()
        {
            Assert.AreEqual(0, _playlist.Count);
        }

        [TestMethod]
        public void NextItem_ShouldReturnNullWhenEmpty()
        {
            Assert.AreSame(null, _playlist.NextItem);
        }

        [TestMethod]
        public void NextItem_ShouldReturnItemsInOrderWhenRandomIsOff()
        {
            _playlist.AddItem(new FileInfo(GetFilePath("short")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("dragonborn")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("gamesofthrone")), -1);

            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("dragonborn.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("gamesofthrone.mp3"));
            Assert.AreSame(null, _playlist.NextItem);
            Assert.IsTrue(_playlist.Ended);
        }

        [TestMethod]
        public void NextItem_ShoulRestartPlayWhenRepeatIsOn()
        {
            _playlist.AddItem(new FileInfo(GetFilePath("short")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("dragonborn")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("gamesofthrone")), -1);
            _playlist.Repeat = true;

            for (int i = 0; i < 3; i++)
            {
                Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("short.mp3"));
                Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("dragonborn.mp3"));
                Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("gamesofthrone.mp3"));   
                Assert.IsFalse(_playlist.Ended);
            }
        }

        [TestMethod]
        public void Reset_ShoulResetPlaylistToBegenning()
        {
            _playlist.AddItem(new FileInfo(GetFilePath("short")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("dragonborn")), -1);
            _playlist.AddItem(new FileInfo(GetFilePath("gamesofthrone")), -1);

            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("dragonborn.mp3"));

            _playlist.Reset();

            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("dragonborn.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("gamesofthrone.mp3"));

            _playlist.Reset();

            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("dragonborn.mp3"));
            Assert.IsTrue(_playlist.NextItem.AudioFile.Name.Contains("gamesofthrone.mp3"));
        }
        
        [TestMethod]
        public void AddItem_ShouldCorrectlyAddItemToPlaylist()
        {
            _playlist.AddItem(new FileInfo(GetFilePath("short")), -1);
            Assert.AreEqual(1, _playlist.Count);

            _playlist.AddItem(new FileInfo(GetFilePath("dragonborn")), -1);
            Assert.AreEqual(2, _playlist.Count);

            Assert.IsTrue(_playlist[0].AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist[1].AudioFile.Name.Contains("dragonborn.mp3"));
        }

        [TestMethod]
        public void AddItem_ShouldAddItemInCorrectOrder()
        {
            _playlist.AddItem(new FileInfo(GetFilePath("short")), 0);
            _playlist.AddItem(new FileInfo(GetFilePath("dragonborn")), 0);
            _playlist.AddItem(new FileInfo(GetFilePath("gamesofthrone")), 0);

            Assert.IsTrue(_playlist[0].AudioFile.Name.Contains("gamesofthrone.mp3"));
            Assert.IsTrue(_playlist[1].AudioFile.Name.Contains("dragonborn.mp3"));
            Assert.IsTrue(_playlist[2].AudioFile.Name.Contains("short.mp3"));

            _playlist.AddItem(new FileInfo(GetFilePath("gamesofthrone")), 3);
            Assert.IsTrue(_playlist[3].AudioFile.Name.Contains("gamesofthrone"));

            _playlist.AddItem(new FileInfo(GetFilePath("short")), 1);
            Assert.IsTrue(_playlist[1].AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist[2].AudioFile.Name.Contains("dragonborn.mp3"));
            Assert.IsTrue(_playlist[3].AudioFile.Name.Contains("short.mp3"));
            Assert.IsTrue(_playlist[4].AudioFile.Name.Contains("gamesofthrone.mp3"));
        }

        private string GetFilePath(string name)
        {
            return string.Format("../../Resources/{0}.mp3", name);
        }
    }
}
