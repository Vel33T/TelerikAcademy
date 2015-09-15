namespace Salaries
{
    using System;

    class Salaries
    {
        static bool[,] matrix;
        static int employeesCount;
        static long[] calculatedSalaries;

        static void Main()
        {
            ProcessInput();

            long totalSalary = 0;
            for (int i = 0; i < employeesCount; i++)
            {
                totalSalary += GetSalary(i);
            }

            Console.WriteLine(totalSalary);
        }

        private static long GetSalary(int employee)
        {
            if (calculatedSalaries[employee] > 0)
            {
                return calculatedSalaries[employee];
            }

            long salary = 0;

            for (int i = 0; i < employeesCount; i++)
            {
                if (matrix[employee, i])
                {
                    salary += GetSalary(i);
                }
            }

            if (salary == 0)
            {
                salary = 1;
            }

            calculatedSalaries[employee] = salary;

            return salary;
        }

        private static void ProcessInput()
        {
            employeesCount = int.Parse(Console.ReadLine());
            matrix = new bool[employeesCount, employeesCount];
            calculatedSalaries = new long[employeesCount];

            for (int i = 0; i < employeesCount; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < employeesCount; j++)
                {
                    if (line[j] == 'Y')
                    {
                        matrix[i, j] = true;
                    }
                }
            }
        }
    }
}
