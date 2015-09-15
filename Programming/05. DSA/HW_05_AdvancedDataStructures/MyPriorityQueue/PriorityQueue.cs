using System;
using System.Collections.Generic;

namespace MyPriorityQueue
{
    public class PriorityQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly List<T> list;

        public PriorityQueue()
        {
            this.list = new List<T>();
        }

        public void Enqueue(T value)
        {
            this.list.Add(value);

            if (list.Count > 1)
            {
                ShiftUp(this.list.Count - 1);
            }
        }

        public T Dequeue()
        {
            if (this.list.Count == 0)
            {
                throw new ArgumentException("No elements in the priority queue");
            }

            T element = this.list[0];
            this.list[0] = this.list[this.list.Count - 1];
            this.list.RemoveAt(this.list.Count - 1);
            ShiftDown(0);

            return element;
        }

        public void ShiftUp(int checkIndex)
        {

            int lastAddedElemntIndex = checkIndex;
            int parentIndex = (lastAddedElemntIndex - 1) / 2;

            if (this.list[parentIndex].CompareTo(this.list[lastAddedElemntIndex]) < 0)
            {
                T changeItem = this.list[parentIndex];
                this.list[parentIndex] = this.list[lastAddedElemntIndex];
                this.list[lastAddedElemntIndex] = changeItem;
                if (parentIndex != 0)
                {
                    ShiftUp(parentIndex);
                }
            }
        }

        public void ShiftDown(int checkIndex)
        {

            int elemntIndexLeft = checkIndex + 1;
            int elemntIndexRight = checkIndex + 2;

            if (this.list[elemntIndexLeft].CompareTo(this.list[elemntIndexRight]) > 0)
            {
                if (this.list[checkIndex].CompareTo(this.list[elemntIndexLeft]) < 0)
                {
                    T changeItem = this.list[checkIndex];
                    this.list[checkIndex] = this.list[elemntIndexLeft];
                    this.list[elemntIndexLeft] = changeItem;
                    checkIndex = elemntIndexLeft;
                    if (checkIndex != this.list.Count)
                    {
                        ShiftUp(checkIndex);
                    }
                }
            }
            else
            {
                if (this.list[checkIndex].CompareTo(this.list[elemntIndexRight]) < 0)
                {
                    T changeItem = this.list[checkIndex];
                    this.list[checkIndex] = this.list[elemntIndexRight];
                    this.list[elemntIndexRight] = changeItem;
                    checkIndex = elemntIndexRight;
                    if (checkIndex != this.list.Count)
                    {
                        ShiftUp(checkIndex);
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.list)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}