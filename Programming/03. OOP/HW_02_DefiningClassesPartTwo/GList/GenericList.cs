using System;
using System.Text;

namespace GList
{
    public class GenericList<T> where T : IComparable
    {
        const int DefaultCapacity = 64;

        private T[] elements;
        private int count = 0;
        private readonly int size = DefaultCapacity;

        //Constructors
        public GenericList(int size = DefaultCapacity)
        {
            this.elements = new T[size];
            this.size = size; //I need the size later on for clearing of the array
        }

        //Properties
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //Indexer
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        #region Methods
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                Grow();
            }
            this.elements[count] = element;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index > count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < count; i++)
            {
                elements[i] = elements[i + 1];
            }
            count--;
        }

        public void InsertAt(T value, int index)
        {
            if (index > count)
            {
                throw new IndexOutOfRangeException();
            }
            if (count >= elements.Length)
            {
                Grow();
            }
            for (int i = count - 1; i >= index; i--)
            {
                elements[i + 1] = elements[i];
            }
            elements[index] = value;
            count++;
        }

        // Making empty array with the same initial size
        public void Clear()
        {
            elements = new T[size];
            count = 0;
        }

        public int Find(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(String.Format("{0} ", elements[i]));
            }
            return result.ToString();
        }

        private void Grow()
        {
            T[] temp = new T[size * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                temp[i] = elements[i];
            }
            elements = temp;
        }

        public T Min()
        {
            T result = elements[0];
            for (int i = 1; i < count; i++)
            {
                if (elements[i].CompareTo(result) < 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }

        public T Max()
        {
            T result = elements[0];
            for (int i = 1; i < count; i++)
            {
                if (elements[i].CompareTo(result) > 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }
        #endregion
    }
}
