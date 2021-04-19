using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Tracks.Tests
{
    [TestClass()]
    public class TrackListTests
    {

        [TestMethod()]
        public void AddTest()
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            Assert.AreEqual(3, trackList.Count);

        }
        [TestMethod()]
        public void RemoveTest()
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            Assert.AreEqual(3, trackList.Count);
            trackList.Remove(t3);
            Assert.AreEqual(2, trackList.Count);

        }
        [TestMethod()]
        public void TotalTimeTest()
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            Time Totaltime = new Time(12,43);
            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            Assert.AreEqual(Totaltime.ToString() , trackList.TotalTime.ToString());
        }
        [TestMethod()]
        public void ShuffleTest()
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList trackList = new TrackList();
            TrackList randomtracklist = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            Assert.AreNotEqual(trackList, trackList.Shuffle());
        }
        
    }
}