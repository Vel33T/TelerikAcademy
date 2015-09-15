using System;

/* Write a program to calculate the sum (with accuracy
 * of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

class SumWithAccuracy
{
    static void Main()
    {
        double previousSum = 1;
        double sum = 0;
        double currentNumber = 0;
        double precission = 0.001;
        double currentPrecission = 1;

        for (int i = 1; currentPrecission >= precission; i++)
        {
            currentNumber = Math.Pow(-1, i + 1) / (i + 1);
            sum = currentNumber + previousSum;
            currentPrecission = Math.Abs(sum - previousSum);
            previousSum = sum;
        }

        Console.WriteLine("The sum is {0}",sum);
    }
}