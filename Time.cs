using System;
using System.Collections.Generic;
using System.Text;
 
namespace AudioDevices
{
    public class Time
    {
        #region Fields
        private int _seconds;
        private int _minutes;
        private int _hours;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        public Time(int seconds)
        {
            _hours = seconds / 3600;
            seconds = seconds % 3600;
            _minutes = seconds / 60;
            _seconds = seconds % 60;

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        public Time(int minutes, int seconds) : this(minutes * 60 + seconds)
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        public Time(int hours, int minutes, int seconds) : this(hours * 3600 + minutes * 60 + seconds)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string time = _hours < 10 ? "0" + _hours.ToString() : _hours.ToString();
            time += ":";
            time += _minutes < 10 ? "0" + _minutes.ToString() : _minutes.ToString();
            time += ":";
            time += _seconds < 10 ? "0" + _seconds.ToString() : _seconds.ToString();
            return time;
        }


        /// <summary>
        /// Gets the length in seconds.
        /// </summary>
        /// <returns></returns>
        public int GetLengthInSeconds()
        {
            return _hours * 3600 + _minutes * 60 + _seconds;
        }
        #endregion

    }
}