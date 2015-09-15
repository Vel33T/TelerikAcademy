using System;

namespace MyPriorityQueue
{
    class Program
    {
        static void Main()
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(3);
            queue.Enqueue(14);
            queue.Enqueue(12);
            queue.Enqueue(5);
            queue.Enqueue(2);

            Console.WriteLine("Printing the queue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dequeue {0}", queue.Dequeue());
            Console.WriteLine("Dequeue {0}", queue.Dequeue());

            Console.WriteLine("Printing the queue again");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
