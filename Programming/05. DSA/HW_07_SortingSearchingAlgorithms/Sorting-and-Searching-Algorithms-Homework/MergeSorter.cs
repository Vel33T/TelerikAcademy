namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection is null. Collection cannot be sorted!");
            }

            int length = collection.Count;
            if (length <= 1)
            {
                return;
            }

            IList<T> sortedCollection = this.MergeSort(collection);

            collection.Clear();
            foreach (T item in sortedCollection)
            {
                collection.Add(item);
            }
        }

        private IList<T> MergeSort(IList<T> collection)
        {
            int length = collection.Count;
            if (length <= 1)
            {
                return collection;
            }

            IList<T> left = new List<T>();
            IList<T> right = new List<T>();
            int middle = length / 2;

            for (int i = 0; i < length; i++)
            {
                if (i < middle)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            left = this.MergeSort(left);
            right = this.MergeSort(right);

            return Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> merged = new List<T>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        merged.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (right.Count > 0)
                {
                    merged.Add(right[0]);
                    right.RemoveAt(0);
                }
                else if (left.Count > 0)
                {
                    merged.Add(left[0]);
                    left.RemoveAt(0);
                }
            }

            return merged;
        }
    }
}
