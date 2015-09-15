using System;

/* Write a program that reads a string from the
 * console and prints all different letters in the 
 * string along with information how many times
 * each letter is found. 
 */

class LettersWithOccurances
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters Write a program that reads a string from the console and prints all different letters.";
        text = text.ToLower();
        int[] values = new int[123];

        foreach (char letter in text)
        {
            if (letter >= 'a' && letter <= 'z')
            {
                values[letter]++;
            }
        }

        for (int i = 0; i < 123; i++)
        {
            if (values[i] != 0)
            {
                Console.WriteLine("Letter: '{0}' is found {1,2} times.", (char)i, values[i]);
            }
        }
    }
}
