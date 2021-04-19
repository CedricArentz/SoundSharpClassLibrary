using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Text;
using AudioDevices.Interfaces;

namespace AudioDevices.Devices.Tests
{
    [TestClass()]
    public class CdDiscManTests
    {
        [TestMethod()]
        public void DisplayIdentityTest()
        {
            CdDiscMan discman = new CdDiscMan(1000);
            discman.Make = "JVC";
            discman.Model = "HG-410";
            Assert.AreEqual(discman.DisplayIdentity(true, true), "Serial: 1000 make: JVC model: HG-410");
        }
        [TestMethod()]
        public void CapacityTest()
        {
            CdDiscMan discman = new CdDiscMan(1000);
            Assert.AreEqual("700 mB.", discman.DisplayStorageCapacity().ToString());
        }
        [TestMethod()]
        public void ResolutionInfoTest()
        {
            CdDiscMan discman = new CdDiscMan(1000);
            discman.DisplayWidth = 320;
            discman.DisplayHeight = 160;
            Assert.AreEqual("51200", discman.TotalPixels.ToString());
            Assert.AreEqual("Resolution: 51200 pixels.", discman.GetResolutionInfo());
        }
        [TestMethod()]
        public void PriceTest()
        {
            CdDiscMan discman = new CdDiscMan(1000);
            discman.PriceExBtw = 149.00M;
            Assert.AreEqual("177,31", discman.ConsumerPrice.ToString());
        }
        [TestMethod()]
        public void EjectTest()
        {
            CdDiscMan discman = new CdDiscMan(1000);
            Assert.AreEqual(true, discman.Eject());       
            Assert.AreEqual(false, discman.Eject());
        }

    }
}