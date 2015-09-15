using System;

namespace MobilePhone
{
    public class Call
    {
        private DateTime dateTime;
        private int duration;
        private string dialedPhoneNumber;

        public Call(string dialedPhoneNumber, int duration, DateTime dateTime)
        {
            this.DateTime = dateTime;
            this.Duration = duration;
            this.DialedPhoneNumber = dialedPhoneNumber;
        }

        #region Properties
        public DateTime DateTime 
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }
        #endregion
    }
}
