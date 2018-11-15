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
                    case "january":
                        // Combines Month with flies(for each month)
                        names.Where(Flies => Flies.January).ToList();
                        break;
                    case "february":
                        names.Where(Flies => Flies.February).ToList();
                        break;
                    case "march":
                        names.Where(Flies => Flies.March).ToList();
                        break;
                    case "april":
                        names.Where(Flies => Flies.April).ToList();
                        break;
                    case "may":
                        names.Where(Flies => Flies.May).ToList();
                        break;
                    case "june":
                        names.Where(Flies => Flies.June).ToList();
                        break;
                    case "July":
                        names.Where(Flies => Flies.July).ToList();
                        break;
                    case "august":
                        names.Where(Flies => Flies.August).ToList();
                        break;
                    case "september":
                        names.Where(Flies => Flies.September).ToList();
                        break;
                    case "october":
                        names.Where(Flies => Flies.October).ToList();
                        break;
                    case "november":
                        names.Where(Flies => Flies.November).ToList();
                        break;
                    case "december":
                        names.Where(Flies => Flies.December).ToList();
                        break;
                    default:
                        break;
                }
                //input = Console.ReadLine();
            }
            List<FlyFishing> listToWrite = new List<FlyFishing>();
            //var result = Console.WriteLine();
            while (input.ToLower() ! = "q")
                {
                switch (input.ToLower())
                {
                    case "january":
                        //Prints the list(for each month)
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.January).ToList();
                        break;
                    case "february":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.February).ToList();
                        break;
                    case "march":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.March).ToList();
                        break;
                    case "april":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.April).ToList();
                        break;
                    case "may":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.May).ToList();
                        break;
                    case "june":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.June).ToList();
                        break;
                    case "july":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.July).ToList();
                        break;
                    case "august":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.August).ToList();
                        break;
                    case "september":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.September).ToList();
                        break;
                    case "october":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.October).ToList();
                        break;
                    case "november":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.November).ToList();
                        break;
                    case "december":
                        PrintResult(names);
                        listToWrite = names.Where(Flies => Flies.December).ToList();
                        break;
                    default:
                        break;
                }
            }

            using (StreamWriter stream = new StreamWriter("Result.csv"))
            using (CsvWriter csvWriter = new CsvWriter(stream)
            {
                csvWriter.WriteRecords(listToWrite);
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



