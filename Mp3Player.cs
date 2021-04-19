using AudioDevices.Tracks;
using System;
using System.Collections.Generic;
using System.Text;
using static AudioDevices.Interfaces.Interfaces;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevice, IDisplay, ITrackList
    {
        private int _mBSize = 0;
        private int _DisplayWidth;
        private int _DisplayHeight;
        private TrackList _TrackList;

        public Mp3Player(int serialId)
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
        public TrackList TrackList => new TrackList();
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }
        public override string DisplayStorageCapacity()
        {
            if (_mBSize < 0)
            {
                return "Storage capacity unknown.";
            }
            else return $"{_mBSize} mB.";
        }
        public bool HasTracks()
        {
            if (TrackList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddTrackList(TrackList trackList)
        {
            trackList.Add(new Track());
        }
        public void RemoveTrackList()
        {
            TrackList.Remove(new Track());
        }
        //public void AddTrackList(TrackList trackList)
        //{
        //    trackList.Add(new Tracks());
        //}
        //public void RemoveTrackList()
        //{
        //    trackList.Remove(new Tracks());
        //}
    }
}