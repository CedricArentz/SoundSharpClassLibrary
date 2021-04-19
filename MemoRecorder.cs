using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Devices
{
    public enum MemoCartridgeType
    {
        C60,
        C90,
        C120,
        Unknown
    }
    public class MemoRecorder:AudioDevice
    {
        private MemoCartridgeType _maxCartridgeType;

        public MemoRecorder(int serialId)
        {
            _serialId = serialId;
        }

        public MemoCartridgeType MaxCartridgeType
        {
            get { return _maxCartridgeType; }
            set { _maxCartridgeType = value; }
            
        }

        

        public override string DisplayStorageCapacity()
        {
            //string Capacity = "Max capacity unknown";
            //if (_maxCartridgeType == MemoCartridgeType.C60)
            //{
            //    Capacity = "Max capacity 60 min.";
            //}
            //else if (_maxCartridgeType == MemoCartridgeType.C90)
            //{
            //    Capacity = "Max capacity 90 min.";
            //}
            //else if (_maxCartridgeType == MemoCartridgeType.C120)
            //{
            //    Capacity = "Max capacity 120 min.";
            //}
            //return Capacity;
            return _maxCartridgeType switch
            {
                MemoCartridgeType.C60 => "Max capacity 60 min.",
                MemoCartridgeType.C90 => "Max capacity 90 min.",
                MemoCartridgeType.C120 => "Max capacity 120 min.",
                MemoCartridgeType.Unknown => "Max capacity unknown",
                _ => "Max capacity unknown"
            };
        }
    }
}