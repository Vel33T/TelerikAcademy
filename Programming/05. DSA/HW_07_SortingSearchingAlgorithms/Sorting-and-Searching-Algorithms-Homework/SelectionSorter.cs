namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection cannot be null!");
            }

            int length = collection.Count;

            for (int i = 0; i < length - 1; i++)
            {
                int minElementIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (collection[j].CompareTo(collection[minElementIndex]) < 0)
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    T swap = collection[i];
                    collection[i] = collection[minElementIndex];
                    collection[minElementIndex] = swap;
                }
            }
        }
    }
}
