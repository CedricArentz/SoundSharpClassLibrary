using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Text;
using static AudioDevices.Interfaces.Interfaces;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevice, IDisplay, ITrackList
    {
        private readonly int _mBSize = 0;
        private int _DisplayWidth;
        private int _DisplayHeight;
        private TrackList _Tracklist;

        public int DisplayWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DisplayHeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int TotalPixels => throw new NotImplementedException();

        public TrackList TrackList => throw new NotImplementedException();

        public void AddTrackList(TrackList trackList)
        {
            throw new NotImplementedException();
        }

        public override string DisplayStorageCapacity()
        {
            throw new NotImplementedException();
        }

        public string GetResolutionInfo()
        {
            throw new NotImplementedException();
        }

        public bool HasTracks()
        {
            throw new NotImplementedException();
        }

        public void RemoveTrackList()
        {
            throw new NotImplementedException();
        }
    }
}