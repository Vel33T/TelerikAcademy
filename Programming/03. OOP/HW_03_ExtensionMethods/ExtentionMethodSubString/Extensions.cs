using System;
using System.Text;

/* Implement an extension method Substring(int 
 * , int length) for the class StringBuilder 
 * that returns new StringBuilder and has the
 * same functionality as Substring in the class String.
 */

namespace ExtentionMethodSubString
{
    public static class Extensions
    {
        // This is the extension method for StringBuilder like String.Substring(int startIndex, int lenght);
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            if (startIndex < 0)
            {
                throw new IndexOutOfRangeException("Start index should be bigger or equal to zero!");
            }
            if (startIndex > input.Length)
            {
                throw new IndexOutOfRangeException("Start index too big! The StringBuilder you are trying to access does not have so much letters!");
            }
            if (length + startIndex > input.Length)
            {
                throw new IndexOutOfRangeException("Length too big! Either choose smaller startIndex or smaller length!");
            }
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }

        // This is the extension method for StringBuilder like String.Substring(int startIndex);
        public static StringBuilder Substring(this StringBuilder input, int startIndex)
        {
            // calling the first method
            return Substring(input, startIndex, input.Length - startIndex);
        }
    }
}
