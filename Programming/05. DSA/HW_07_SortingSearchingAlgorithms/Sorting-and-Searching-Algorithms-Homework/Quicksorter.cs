namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection cannot be null!");
            }

            QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            T pivot = collection[leftIndex];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T swapValue = collection[i];
                    collection[i] = collection[j];
                    collection[j] = swapValue;

                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(collection, leftIndex, j);
            }

            if (rightIndex > i)
            {
                QuickSort(collection, i, rightIndex);
            }
        }
    }
}
