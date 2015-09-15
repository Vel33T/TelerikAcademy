namespace MinimumEditDistance
{
    using System;

    class MinimumEditDistance
    {
        private const double CostDelete = 0.9;
        private const double CostInsert = 0.8;
        private const double CostReplace = 1;

        static void Main()
        {
            Console.WriteLine(ComputeCost("developer", "enveloped"));
            Console.WriteLine(ComputeCost("developer", "eveloper"));
            Console.WriteLine(ComputeCost("eveloper", "enveloper"));
            Console.WriteLine(ComputeCost("enveloper", "enveloped"));
        }

        private static double ComputeCost(string firstWord, string secondWord)
        {
            int n = firstWord.Length;
            int m = secondWord.Length;
            double[,] table = new double[n + 1, m + 1];

            for (int row = 0; row <= n; row++)
            {
                table[row, 0] = row * CostDelete;
            }

            for (int col = 0; col <= m; col++)
            {
                table[0, col] = col * CostInsert;
            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= m; col++)
                {
                    double cost = (secondWord[col - 1] == firstWord[row - 1]) ? 0 : CostReplace;

                    double delete = table[row - 1, col] + CostDelete;
                    double insert = table[row, col - 1] + CostInsert;
                    double replace = table[row - 1, col - 1] + cost;

                    table[row, col] = Math.Min(Math.Min(delete, insert), replace);
                }
            }

            return table[n, m];
        }
    }
}
