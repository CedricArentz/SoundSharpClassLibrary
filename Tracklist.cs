using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AudioDevices.Tracks
{
    public class TrackList
    {
        private List<Track> _tracks;
        private List<Track> _randomtracks;
        private int _count;
        private Time _totaltime;

        public TrackList() => _tracks = new List<Track>();

        public TrackList(List<Track> _tracks)
        {
            this._tracks = _tracks;
        }

        //Aantal tracks in de tracklist
        public int Count
        {
            get
            {
                return _tracks.Count;
            }
        }
        //Totale tijd van de tracklist
        public Time TotalTime
        {
            get
            {
                int timeInSeconds = 0;
                foreach (Track t in _tracks)
                {
                    timeInSeconds += t.GetLengthInSeconds();
                }

                Time totalTime = new Time(timeInSeconds);
                return totalTime;
            }
        }

        public void Add(Track t)
        {
            _tracks.Add(t);
        }
        public void Remove(Track t)
        {
            _tracks.Remove(t);
        }
        public void Clear(Track t)
        {
            _tracks.Clear();
        }
        public List<Track> GetAllTracks()
        {
            return _tracks;
        }
        public List<Track> Shuffle()
        {
            _randomtracks = _tracks.OrderBy(x => Guid.NewGuid()).ToList();
            return _tracks;
        }
    }
}