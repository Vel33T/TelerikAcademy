namespace Frames
{
    using System;

    public class Pair : IComparable<Pair>
    {
        public string[] Numbers { get; set; }

        public Pair(string[] numbers)
        {
            this.Numbers = new string[2];
            this.Numbers = numbers;
            Array.Sort(Numbers);
        }

        public int CompareTo(Pair other)
        {
            int resultOfCompare = Numbers[0].CompareTo(other.Numbers[0]);
            if (resultOfCompare == 0)
            {
                resultOfCompare = Numbers[1].CompareTo(other.Numbers[1]);
            }
            return resultOfCompare;
        }
    }
}
