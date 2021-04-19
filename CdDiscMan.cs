using System;
using System.Collections.Generic;
using System.Text;
using static AudioDevices.Interfaces.Interfaces;

namespace AudioDevices.Devices
{
    public class CdDiscMan : AudioDevice, IDisplay
    {
        private readonly int _mBSize = 700;
        private int _DisplayWidth;
        private int _DisplayHeight;
        private bool _isEjected = false;

        public CdDiscMan(int serialId)
        {
            _serialId = serialId;
        }


        public int DisplayWidth
        {
            get { return _DisplayWidth; }
            set { _DisplayWidth = value; }
        }
        public int DisplayHeight
        {
            get { return _DisplayHeight; }
            set { _DisplayHeight = value; }
        }
        public int TotalPixels
        {
            get { return _DisplayWidth * _DisplayHeight; }
        }

        public int MbSize
        {
            get { return _mBSize; }
        }
        public bool IsEjected
        {
            get { return _isEjected; }
        }


        public override string DisplayStorageCapacity()
        {
            return $"{_mBSize} mB.";
        }

        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }

        public bool Eject()
        {
            if (_isEjected == true)
            {
                _isEjected = false;
            }
            else if (_isEjected == false)
            {
                _isEjected = true;
            }
            return _isEjected;
        }
    }
}