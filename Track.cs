using System;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AudioDevices.Tracks
{
    public class Track
    {
        #region Fields
        private int _id;
        private string _name;
        private string _artist;
        private string _albumSource;
        private Category _style;
        private Time _length;
        #endregion


        #region Constructors
        public Track()
        {

        }
        public Track(int id)
        {
            _id = id;
        }
        public Track(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public Track(int id, string artist, string name)
        {
            _id = id;
            _artist = artist;
            _name = name;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the artist.
        /// </summary>
        /// <value>
        /// The artist.
        /// </value>
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName
        {
            get
            {
                if (Name == null || Artist == null)
                {
                    return "Onbekend";
                }
                else
                {
                    return Artist + " - " + Name;
                }
            }
        }

        /// <summary>
        /// Sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public Time Length
        {

            set
            {
                _length = value;
            }
        }

        /// <summary>
        /// Gets the display length.
        /// </summary>
        /// <value>
        /// The display length.
        /// </value>
        public string DisplayLength
        {
            get
            {
                return _length.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        public Category Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }

        /// <summary>
        /// Gets or sets the album source.
        /// </summary>
        /// <value>
        /// The album source.
        /// </value>
        public string AlbumSource
        {
            get { return _albumSource; }
            set { _albumSource = value; }
        }

        public Time Time
        {
            get => default;
            set
            {
            }
        }

        public Category Category
        {
            get => default;
            set
            {
            }
        }

        public TrackList TrackList
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <returns></returns>
        public Time GetLength()
        {
            return _length;
        }

        /// <summary>
        /// Gets the length in seconds.
        /// </summary>
        /// <returns></returns>
        public int GetLengthInSeconds()
        {
            return _length.GetLengthInSeconds();
        }
        #endregion
    }

}