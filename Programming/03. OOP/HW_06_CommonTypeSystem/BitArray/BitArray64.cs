using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; set; }

        //Constructor
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        //Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index range is [0, 63]");
                }
                return (Number & ((ulong)1 << index)) != 0 ? 1 : 0;
            }
        }

        //IEnumerator implementation
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 array = obj as BitArray64;
            if (array == null)
            {
                return false;
            }
            if (!Object.Equals(this.Number, array.Number))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return Object.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !Object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                result.Append(this[i]);
            }
            return result.ToString();
        }
    }
}
