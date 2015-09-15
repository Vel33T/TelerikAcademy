using System;
using System.Collections.Generic;
using System.Linq;

/* Implement a set of extension methods for
 * IEnumerable<T> that implement the following
 * group functions: sum, product, min, max, average.
 */

namespace ExtentionMethodsIEnumerable
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = 0;
            foreach (var number in input)
            {
                result += number;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = 1;
            foreach (var number in input)
            {
                result *= number;
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = 1;
            foreach (var number in input)
            {
                result += number;
            }
            result /= input.Count();
            return result;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = int.MaxValue;
            foreach (var number in input)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = int.MinValue;
            foreach (var number in input)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
    }
}
