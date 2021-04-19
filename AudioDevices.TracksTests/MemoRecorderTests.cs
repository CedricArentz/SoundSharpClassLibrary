using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Devices.Tests
{
    [TestClass()]
    public class MemoRecorderTests
    {
        [TestMethod()]
        public void DisplayStorageCapacityTest()
        {
            MemoRecorder memo = new MemoRecorder(1000);
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);
            Assert.AreEqual(memo.DisplayStorageCapacity(), "Max capacity 90 min.");

        }
        [TestMethod()]
        public void DisplayIdentityTest()
        {
            MemoRecorder memo = new MemoRecorder(1000);
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.SerialId = 500;
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);
            Assert.AreEqual("Serial: 500", memo.DisplayIdentity());

        }
        [TestMethod()]
        public void ConsumerPriceTest()
        {
            MemoRecorder memo = new MemoRecorder(1000);
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.SerialId = 500;
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);
            Assert.AreEqual("154,64", memo.ConsumerPrice.ToString());
        }
        [TestMethod()]
        public void GetDeviceLifeTimeTest()
        {
            MemoRecorder memo = new MemoRecorder(1000);
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.SerialId = 500;
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);
            Assert.AreEqual("Lifetime 182 days", memo.GetDeviceLifeTime());
        }
    }
}