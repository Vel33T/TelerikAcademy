using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using System.Threading;
using System.Globalization;

namespace SupermarketQueue
{
    public class SupermarketQueue
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Supermarket queue = new Supermarket();

            StringBuilder answer = new StringBuilder();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string commandResult = queue.ProcessCommand(command);
                answer.AppendLine(commandResult);
                command = Console.ReadLine();
            }
            answer.Length--;
            Console.WriteLine(answer);
        }
    }


    public class Supermarket
    {
        private const string Ok = "OK";
        private const string Error = "Error";

        private static BigList<string> bigList;
        private static Dictionary<string, int> pplCount;

        public Supermarket()
        {
            bigList = new BigList<string>();
            pplCount = new Dictionary<string, int>();
        }

        private string Append(string name)
        {
            bigList.Add(name);
            if (!pplCount.ContainsKey(name))
            {
                pplCount.Add(name, 1);
            }
            else
            {
                pplCount[name]++;
            }

            return Ok;
        }

        private string Insert(int position, string name)
        {
            if (position > bigList.Count)
            {
                return Error;
            }

            bigList.Insert(position, name);
            if (!pplCount.ContainsKey(name))
            {
                pplCount.Add(name, 1);
            }
            else
            {
                pplCount[name]++;
            }

            return Ok;
        }

        private string Find(string name)
        {
            if (!pplCount.ContainsKey(name))
            {
                return "0";
            }

            int value = 0;
            pplCount.TryGetValue(name, out value);

            return value.ToString();
        }

        private string Serve(int count)
        {
            if (count <= bigList.Count)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    sb.AppendFormat("{0} ", bigList[i]);
                    pplCount[bigList[i]]--;
                }
                sb.Length--;
                bigList.RemoveRange(0, count);

                return sb.ToString();
            }
            else
            {
                return Error;
            }
        }

        public string ProcessCommand(string command)
        {
            string[] parameters = command.Split(' ');
            string commandResults = String.Empty;

            switch (parameters[0])
            {
                case "Append":
                    {
                        commandResults = Append(parameters[1]);
                        break;
                    }
                case "Insert":
                    {
                        commandResults = Insert(int.Parse(parameters[1]), parameters[2]);
                        break;
                    }
                case "Find":
                    {
                        commandResults = Find(parameters[1]);
                        break;
                    }
                case "Serve":
                    {
                        commandResults = Serve(int.Parse(parameters[1]));
                        break;
                    }
            }

            return commandResults;
        }
    }
}
