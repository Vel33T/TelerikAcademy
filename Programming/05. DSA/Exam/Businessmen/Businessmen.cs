﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businessmen
{
    class Businessmen
    {
        static void Main()
        {
            long[] catalan = new long[] { 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440, 9694845, 35357670, 129644790, 477638700, 1767263190, 6564120420, 24466267020, 91482563640, 343059613650, 1289904147324, 4861946401452, 18367353072152, 69533550916004, 263747951750360, 1002242216651368, 3814986502092304, 14544636039226909, 55534064877048198, 212336130412243110, 812944042149730764, 3116285494907301262 };
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(catalan[n/2]);
        }
    }
}
