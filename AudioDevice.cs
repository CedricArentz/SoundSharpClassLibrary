using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        //Unieke numerieke serialId van het device.
        protected int _serialId;
        //Modelnaam van het device.
        protected string _model;
        //Merk van het device
        protected string _make;
        //Prijs van het device exclusief BTW.
        protected decimal _priceExBtw;
        //Datum/Tijd waarop het device gemaakt is.
        protected DateTime _creationDate;
        //BTW Percentage
        protected readonly static double btwPercentage = 19.0;
        //Prijs van het device inclusief BTW.
        protected decimal _ConsumerPrice;

        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public int SerialId
        {
            get { return _serialId; }
            set { _serialId = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public decimal PriceExBtw
        {
            get { return _priceExBtw; }
            set { _priceExBtw = value; }
        }

        public decimal ConsumerPrice
        {
            get 
            {
                return Math.Round(PriceExBtw + (PriceExBtw * ((decimal)btwPercentage / 100)), 2);
            }
        }

        public string DisplayIdentity()
        {
            string text = $"Serial: {_serialId}";
            return text;
        }
        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string text = $"Serial: {_serialId} ";
            if (makeInfo == true)
            {
                text += $"make: {_make} ";
            }
            if (modelInfo == true)
            {
                text += $"model: {_model}";
            }
            return text;
        }

        public String GetDeviceLifeTime()
        {
            if (_creationDate != null)
            {
                TimeSpan diff = DateTime.Now.Subtract(this._creationDate);
                return $"Lifetime {diff.Days} days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }
        public abstract String DisplayStorageCapacity();

    }
}