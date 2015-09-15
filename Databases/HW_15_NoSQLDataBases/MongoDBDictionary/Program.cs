using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDictionary
{
    class Program
    {
        static void Main()
        {
            string connectionStr = @"mongodb://dev:1234@ds063297.mongolab.com:63287/db-project-product-reports";
            var client = new MongoClient(connectionStr);
            var server = client.GetServer();
            var dictionaryDB = server.GetDatabase("db-project-product-reports"); // Used database from teamwork
            var wordCollection = dictionaryDB.GetCollection<Word>("dictionary");
            var wordCollectionQueery = wordCollection.AsQueryable();

            Console.WriteLine("This is MongoDB console dictionary");

            while (true)
            {
                WriteOptions();

                string command = Console.ReadLine();

                if (command == "exit")
                {
                    break;
                }

                int parsedCommand = 0;
                try
                {
                    parsedCommand = int.Parse(command);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter number from 1 to 3 including.");
                }

                switch (parsedCommand)
                {
                    case 1: AddNewWordAndTranslation(wordCollection); break;
                    case 2: ListWordsAndTranslations(wordCollectionQueery); break;
                    case 3: FindTranslation(wordCollectionQueery); break;
                    default:
                        break;
                }
            }
        }

        private static void FindTranslation(IQueryable<Word> wordCollection)
        {
            Console.Write("Search for: ");
            var searchWord = Console.ReadLine();

            var word = wordCollection.Where(w => w.Name == searchWord).ToList();

            foreach (Word item in word)
            {
                Console.WriteLine("Translation: " + item.Translation);
            }
        }

        private static void ListWordsAndTranslations(IQueryable<Word> wordCollection)
        {
            var words = wordCollection.ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Word item in words)
            {
                sb.Append(item.Name + " --> " + item.Translation);
                sb.Append("\n");
            }

            Console.WriteLine(sb);
        }

        private static void AddNewWordAndTranslation(MongoCollection<Word> wordCollection)
        {
            Console.Write("Word: ");
            string word = Console.ReadLine();
            Console.Write("Translation: ");
            string translation = Console.ReadLine();

            Word newWord = new Word()
            {
                Name = word,
                Translation = translation
            };

            wordCollection.Insert(newWord);
        }

        private static void WriteOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Press 1, to add new word and translataion.");
            Console.WriteLine("Press 2, to list all words and their translataions.");
            Console.WriteLine("Press 3, to find translation of given word.");
            Console.WriteLine("For exit write: exit");
            Console.WriteLine();
        }
    }

    public class Word
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Translation { get; set; }
    }

}
