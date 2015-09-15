using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoverMessage
{
    class RecoverMessage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] parts = new string[n];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                parts[i] = Console.ReadLine();
            }

            Array.Sort(parts);

            for (int i = 0; i < n; i++)
            {
                sb.Append(parts[i]);
            }


            Console.WriteLine(sb);
        }
    }
}
