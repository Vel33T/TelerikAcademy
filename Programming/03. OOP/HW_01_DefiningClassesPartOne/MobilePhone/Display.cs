using System;
using System.Text;

namespace MobilePhone
{
    public class Display
    {
        private int? size;
        private int? numberOfColors;

        #region Constructors
        public Display(int size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public Display(int size)
            : this(size, null)
        {
        }

        public Display()
        {
            this.Size = null;
            this.NumberOfColors = null;
        }
        #endregion

        #region Properties
        public int? Size
        {
            get { return this.size; }
            set
            {
                if (value >= 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("----Display----");
            if (this.size != null)
            {
                result.AppendLine(this.size.ToString());
            }
            if (this.numberOfColors != null)
            {
                result.AppendLine(this.numberOfColors.ToString());
            }
            return result.ToString();
        }
        #endregion
    }
}
