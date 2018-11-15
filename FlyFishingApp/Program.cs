using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyFishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be sure to install CSVHelper nuget package to project before running project

            List<FlyFishing> names;

            // Reads Data from CSV file
            using (var streamReader = new StreamReader("../../HatchChart.csv"))
            using (var reader = new CsvReader(streamReader))
            {
                reader.Configuration.RegisterClassMap<FlyMap>();
                names = reader.GetRecords<FlyFishing>().ToList();
            }

            // Writes file to a text file
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string fileToWrite = Path.Combine(directory.FullName, "flyResult.txt");

            // Starts the app, Asks for user input
            Console.WriteLine("Welcome to the fly fishing App!");
            Console.WriteLine("Please select the month you would like to go fishing to return a list of flies " +
                             "that are active.");
            // Provides a way for the user to exit the program
            Console.WriteLine("Please press Q to exit the program.");

            // Gets the input
            var input = Console.ReadLine();
            

            List<FlyFishing> listToWrite = new List<FlyFishing>();
            //var result = Console.WriteLine();
            while (input.ToLower() != "q")
            {
                switch (input.ToLower())
                {
                    case "january":
                        //Prints the list(for each month)
                        listToWrite = names.Where(Flies => Flies.January).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        
                        break;
                    case "february":
                        listToWrite = names.Where(Flies => Flies.February).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "march":
                        listToWrite = names.Where(Flies => Flies.March).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "april":
                        listToWrite = names.Where(Flies => Flies.April).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "may":
                        listToWrite = names.Where(Flies => Flies.May).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "june":
                        listToWrite = names.Where(Flies => Flies.June).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "july":
                        listToWrite = names.Where(Flies => Flies.July).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "august":
                        listToWrite = names.Where(Flies => Flies.August).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "september":
                        listToWrite = names.Where(Flies => Flies.September).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "october":
                        listToWrite = names.Where(Flies => Flies.October).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "november":
                        listToWrite = names.Where(Flies => Flies.November).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    case "december":
                        listToWrite = names.Where(Flies => Flies.December).ToList();
                        PrintResult(listToWrite);
                        SaveResult(listToWrite);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            
        }
        // Prints the list to the console

        private static void PrintResult(List<FlyFishing> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name.Name);
            }
        }
        private static void SaveResult(List<FlyFishing> names)
        {
            using (StreamWriter stream = new StreamWriter("Result.csv"))
            using (CsvWriter csvWriter = new CsvWriter(stream))
            {
                csvWriter.WriteRecords(names);
            }
        }
    }
}

 
 



