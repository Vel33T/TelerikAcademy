namespace ColoredRabbits
{
    using System;

    class ColoredRabbits
    {
        static void Main()
        {
            int askedRabbits = int.Parse(Console.ReadLine());
            int[] answers = new int[askedRabbits];

            for (int i = 0; i < askedRabbits; i++)
            {
                answers[i] = int.Parse(Console.ReadLine());
            }

            int[] countAnswers = new int[1000002];
            for (int i = 0; i < askedRabbits; i++)
            {
                countAnswers[answers[i] + 1]++;
            }

            int rabbits = 0;
            for (int i = 0; i < 1000002; i++)
            {
                if (countAnswers[i] == 0)
                {
                    continue;
                }

                if (countAnswers[i] <= i)
                {
                    rabbits += i;
                }
                else
                {
                    rabbits += (int)Math.Ceiling((double)countAnswers[i] / i) * i;
                }
            }

            Console.WriteLine(rabbits);
        }
    }
}
