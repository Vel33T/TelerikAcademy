using System;
using System.IO;
using System.Text;

namespace TraverseWindowsDirectory
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\WINDOWS";

            GetDirectories(path);

            Console.WriteLine("End");
        }

        public static void GetDirectories(string path)
        {
            try
            {
                PrintExes(path);

                string[] directories = Directory.GetDirectories(path);

                if (directories.Length > 0)
                {
                    foreach (var directory in directories)
                    {
                        GetDirectories(directory);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Cannot access directory {0}!", path);
                return;
            }
        }

        private static void PrintExes(string path)
        {
            StringBuilder result = new StringBuilder();

            string searchedFileExtention = @"*.exe";
            string[] exes = Directory.GetFiles(path, searchedFileExtention);

            for (int i = 0; i < exes.Length; i++)
            {
                result.Append(exes[i]);
                result.Append(Environment.NewLine); 
            }
            
            Console.WriteLine(result);
        }
    }
}
