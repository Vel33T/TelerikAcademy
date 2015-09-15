using System;

// Problem 5 - Pillars

class Pillars
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        int number6 = int.Parse(Console.ReadLine());
        int number7 = int.Parse(Console.ReadLine());
        int number8 = int.Parse(Console.ReadLine());

        // We will start counting the bites from the left side, then to the right side


        int bytesNumber = 0;
        int bestPillar = 0;
        bool pillar = false;    //this will be used to know if there is an existing pillar

        for (int currentPillar = 7; currentPillar >= 0; currentPillar--)
        {
            
            int bytesLeftSide = 0;
            for (int i = 7; i > currentPillar; i--)
            {
                bytesLeftSide += (number1 >> i) & 1;
                bytesLeftSide += (number2 >> i) & 1;
                bytesLeftSide += (number3 >> i) & 1;
                bytesLeftSide += (number4 >> i) & 1;
                bytesLeftSide += (number5 >> i) & 1;
                bytesLeftSide += (number6 >> i) & 1;
                bytesLeftSide += (number7 >> i) & 1;
                bytesLeftSide += (number8 >> i) & 1;
            }

            // Counting bytes standing on the right of the pillar
            int bytesRightSide = 0;
            for (int i = currentPillar - 1; i >= 0; i--)
            {
                bytesRightSide += (number1 >> i) & 1;
                bytesRightSide += (number2 >> i) & 1;
                bytesRightSide += (number3 >> i) & 1;
                bytesRightSide += (number4 >> i) & 1;
                bytesRightSide += (number5 >> i) & 1;
                bytesRightSide += (number6 >> i) & 1;
                bytesRightSide += (number7 >> i) & 1;
                bytesRightSide += (number8 >> i) & 1;
            }

            //checking if the bytes are equal on both sides
            if (bytesLeftSide == bytesRightSide)
            {
                bestPillar = currentPillar;
                bytesNumber = bytesLeftSide;
                pillar = true;
                break;
            }
        }

        //printing the results
        if (pillar)
        {
            Console.WriteLine(bestPillar);
            Console.WriteLine(bytesNumber);
        }
        else
            Console.WriteLine("No");
    }
}
