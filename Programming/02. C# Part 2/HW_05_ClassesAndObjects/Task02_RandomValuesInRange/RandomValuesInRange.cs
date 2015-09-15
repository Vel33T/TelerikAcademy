using System;

/* Write a program that generates and prints to the
 * console 10 random values in the range [100, 200].
 */

class RandomValuesInRange
{
    static void Main()
    {
        Random rand = new Random();
        int randomNumber = 0;
        for (int i = 0; i < 10; i++)
        {
            randomNumber = rand.Next(100,201);
            Console.WriteLine(randomNumber);
        }
    }
}
