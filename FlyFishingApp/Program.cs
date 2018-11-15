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
            // keeps going unless user enters q
            while (input.ToLower() != "q")
            {
                switch (input.ToLower())
                {
                    case "January":
                        //Prints the list(for each month)
                        PrintResult(names);
                        // Combines Month with flies(for each month)
                        names.Where(Flies => Flies.January).ToList();
                        break;
                    case "February":
                        PrintResult(names);
                        names.Where(Flies => Flies.February).ToList();
                        break;
                    case "March":
                        PrintResult(names);
                        names.Where(Flies => Flies.March).ToList();
                        break;
                    case "April":
                        PrintResult(names);
                        names.Where(Flies => Flies.April).ToList();
                        break;
                    case "May":
                        PrintResult(names);
                        names.Where(Flies => Flies.May).ToList();
                        break;
                    case "June":
                        PrintResult(names);
                        names.Where(Flies => Flies.June).ToList();
                        break;
                    case "July":
                        PrintResult(names);
                        names.Where(Flies => Flies.July).ToList();
                        break;
                    case "August":
                        PrintResult(names);
                        names.Where(Flies => Flies.August).ToList();
                        break;
                    case "September":
                        PrintResult(names);
                        names.Where(Flies => Flies.September).ToList();
                        break;
                    case "October":
                        PrintResult(names);
                        names.Where(Flies => Flies.October).ToList();
                        break;
                    case "November":
                        PrintResult(names);
                        names.Where(Flies => Flies.November).ToList();
                        break;
                    case "December":
                        PrintResult(names);
                        names.Where(Flies => Flies.December).ToList();
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
                Console.WriteLine(name.ToString());
            }
        }
        
    }
}
