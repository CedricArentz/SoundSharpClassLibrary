using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;

namespace AudioDevices.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void TimeTest()
        {
            Time t = new Time(150);

            Assert.AreEqual("00:02:30", t.ToString());
        }

        [TestMethod()]
        public void Time2ParamsTest()
        {
            Time t = new Time(3, 65);

            Assert.AreEqual("00:04:05", t.ToString());
        }

        [TestMethod()]
        public void GetLengthInSecondsTest()
        {
            Time t = new Time(3, 4, 2);
            Assert.AreEqual(11042, t.GetLengthInSeconds());
        }

        [TestMethod()]
        public void GetLengthTest()
        {
            Track t2 = new Track();
            t2.Length = new Time(100);
            Assert.AreEqual(new Time(0, 1, 40).ToString(), t2.GetLength().ToString());

        }
    }
}