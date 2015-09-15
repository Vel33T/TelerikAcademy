namespace FriendsOfPesho
{
    using System;
    using System.Linq;

    // 60/100 BgCoder I think it is because of the LINQ implementation
    // I should have tried with PriorityQueue implementation but I have no time. :)

    public class FriendsOfPeshoMain
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int nodes = int.Parse(firstLine[0]);
            int edges = int.Parse(firstLine[1]);
            int numberOfHospitals = int.Parse(firstLine[2]);
            string[] hospitals = Console.ReadLine().Split(' ');

            Graph graph = new Graph();
            for (int i = 1; i <= nodes; i++)
            {
                graph.AddNode(i.ToString());
            }

            for (int i = 0; i < edges; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                graph.AddConnection(edge[0], edge[1], int.Parse(edge[2]), true);
            }

            int minDistance = int.MaxValue;
            for (int i = 0; i < numberOfHospitals; i++)
            {
                var calculator = new DistanceCalculator();
                var distances = calculator.CalculateDistances(graph, hospitals[i]);
                int currentDistance = 0;
                foreach (var distance in distances)
                {
                    if (!hospitals.Contains(distance.Key))
                    {
                        currentDistance += (int)distance.Value;
                    }
                }
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }
            }
            Console.WriteLine(minDistance);
        }
    }
}