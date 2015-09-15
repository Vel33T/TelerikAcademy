using System;
using System.Text;

namespace MobilePhone
{
    public class Battery
    {
        private string type = null;
        private BatteryType model;
        private int? hoursIdle;
        private int? hoursTalk;

        #region Constructors
        public Battery(BatteryType model, int? hoursIdle, int? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(BatteryType model, int? hoursIdle)
            : this(model, hoursIdle, null)
        {
        }

        public Battery(BatteryType model)
            : this(model, null, null)
        {
        }

        public Battery()
        {
            this.Type = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }
        #endregion

        #region Properties
        public BatteryType Model { get; set; }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Type { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("----Battery----");
            if (this.type != null)
            {
                result.AppendLine(this.type.ToString());
            }
            else
            {
                result.AppendLine(this.model.ToString());
            }
            if (this.hoursIdle != null)
            {
                result.AppendLine(this.hoursIdle.ToString());
            }
            if (this.hoursTalk != null)
            {
                result.AppendLine(this.hoursTalk.ToString());
            }
            return result.ToString();
        }
        #endregion
    }
}
