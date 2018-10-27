using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "HatchChart.csv");
            var fileContents = ReadFlyFishingResults(fileName);
            Console.Read();
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> ReadFlyFishingResults(string fileName)
        {
            var flyFishingResults = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                while (reader.Peek() > -1)
                {
                    string[] line = reader.ReadLine().Split(',');
                    flyFishingResults.Add(line);
                }
            }
            return flyFishingResults;
        }
    }


   
}
