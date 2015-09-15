using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private string owner;
        private int? price;

        static private GSM iPhone4S = new GSM("IPhone4S", "Apple", "Velizar Velizarov", 9000);

        private List<Call> callHistory = new List<Call>();

        #region Constructors
        public GSM(string model, string manufacturer, string owner, int? price, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, string owner, int? price, Battery battery)
            : this(model, manufacturer, owner, price, battery, null)
        {
        }

        public GSM(string model, string manufacturer, string owner, int? price)
            : this(model, manufacturer, owner, price, null, null)
        {
        }

        public GSM(string model, string manufacturer, int? price)
            : this(model, manufacturer, null, price, null, null)
        {
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer, owner, null, null, null)
        {
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }
        #endregion

        #region Properties
        public static GSM IPhone4S 
        {
            get
            {
                return iPhone4S;
            } 
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length >= 0 || value == null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length >= 0 || value == null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length >= 0 || value == null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory { get; set; }
        #endregion

        #region Methods
        //Overriding ToString();
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("----------GSM----------");
            result.AppendLine(this.model);
            result.AppendLine(this.manufacturer);
            if (this.owner != null)
            {
                result.AppendLine(this.owner);
            }
            if (this.price != null)
            {
                result.AppendLine(this.price.ToString());
            }
            if (this.Battery != null)
            {
                result.AppendLine(this.Battery.ToString());
            }
            if (this.Display != null)
            {
                result.AppendLine(this.Display.ToString());
            }
            return result.ToString();
        }

        // Adding to call history
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        //Deleting from call history
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        //Clearing all call history
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        //Total price of the calls
        public decimal TotalPriceOfCalls(decimal pricePerMinute)
        {
            decimal totalTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime += Math.Ceiling((decimal)callHistory[i].Duration);
            }
            decimal price = totalTime + pricePerMinute;
            return price;
        }

        //Removing the longest call 
        #endregion

    }
}
