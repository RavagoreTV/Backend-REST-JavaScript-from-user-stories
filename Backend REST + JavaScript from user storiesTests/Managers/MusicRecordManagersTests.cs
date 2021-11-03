using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend_REST___JavaScript_from_user_stories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend_REST___JavaScript_from_user_stories.Model;

namespace Backend_REST___JavaScript_from_user_stories.Managers.Tests
{
    [TestClass()]
    public class MusicRecordManagersTests
    {
        MusicRecordManagers records = new MusicRecordManagers();

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.AreEqual(4, records.GetAll().Count);
        }

        [TestMethod()]
        public void GetByTitleTest()
        {
            Assert.AreEqual("i cant sing for shit", records.GetByTitle("i cant sing for shit").Title);
        }

        [TestMethod()]
        public void AddTest()
        {
            var newrecord = records.Add(new MusicRecords()
            { Artist = "Finn pølse", Duration = 3, PublicationYear = 1932, Title = "storytime" });
            Assert.AreEqual("storytime", newrecord.Title);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = records.Delete("99 luftballon");
            Assert.AreEqual("99 luftballon", result.Title);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = records.Add(new MusicRecords() { Artist = "pølsefest", Duration = 4, PublicationYear = 1988, Title = "i sengen" });
            var updatedmusic = records.Update("i sengen", result);
            updatedmusic.Title = "What ever";
            updatedmusic.Artist = "Hej";
            updatedmusic.Duration = 214;
            updatedmusic.PublicationYear = 1935;

            result.Title = updatedmusic.Title;
            result.Artist = updatedmusic.Artist;
            result.Duration = updatedmusic.Duration;
            result.PublicationYear = updatedmusic.PublicationYear;

            Assert.AreEqual(result.Title, updatedmusic.Title);
            Assert.AreEqual(result.Artist, updatedmusic.Artist);
            Assert.AreEqual(result.Duration, updatedmusic.Duration);
            Assert.AreEqual(result.PublicationYear, updatedmusic.PublicationYear);

        }
    }
}