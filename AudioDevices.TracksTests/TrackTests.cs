using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks.Tests
{
    [TestClass()]
    public class TrackTests
    {
        [TestMethod()]
        public void DisplayNameTest()
        {
            Track t = new Track();

            Assert.AreEqual("Onbekend", t.DisplayName);
        }

        [TestMethod()]
        public void DisplayNameTest1()
        {
            Track t = new Track();
            t.Artist = "Coldplay";
            t.Name = "Fix You";
            Assert.AreEqual("Coldplay - Fix You", t.DisplayName);
        }

        [TestMethod()]
        public void DisplayNameTest2()
        {
            {
                Track t = new Track();
                t.Artist = "Coldplay";
                Assert.AreEqual("Onbekend", t.DisplayName);
            }
        }
        [TestMethod()]
        public void DisplayNameTest3()
        {
            {
                Track t = new Track();
                t.Name = "Fix You";
                Assert.AreEqual("Onbekend", t.DisplayName);
            }
        }

        [TestMethod]
        public void TrackTimeTest()
        {
            Time t = new Time(100);
            Track t1 = new Track();
            t1.Length = t;

            Assert.AreEqual("00:01:40", t1.DisplayLength);
        }

    }
}