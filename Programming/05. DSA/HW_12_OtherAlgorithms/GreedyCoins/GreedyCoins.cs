namespace GreedyCoins
{
    using System;

    class GreedyCoins
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] counter = new int[3];

            // 6te se napravq na udaren :)
            while (n != 0)
            {
                if (n - 5 > 0)
                {
                    counter[0]++;
                    n -= 5;
                }
                else if (n - 2 > 0)
                {
                    counter[1]++;
                    n -= 2;
                }
                else
                {
                    counter[2]++;
                    n--;
                }
            }

            //counter[0] = n / 5;
            //n %= 5;
            //counter[1] = n / 2;
            //n %= 2;
            //counter[2] = n / 1;


            Console.WriteLine("{0} coins x 5 + {1} coins x 2 + {2} coins x 1", counter[0], counter[1], counter[2]);
        }
    }
}
