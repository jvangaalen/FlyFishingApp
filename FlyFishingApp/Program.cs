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
            List<FlyFishing> names;
            using (var streamReader = new StreamReader("../../HatchChart.csv"))
            using (var reader = new CsvReader(streamReader))
            {
                reader.Configuration.RegisterClassMap<FlyMap>();
                names = reader.GetRecords<FlyFishing>().ToList();
            }

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string fileToWrite = Path.Combine(directory.FullName, "flyResult.txt");

            Console.WriteLine("Welcome to the fly fishing App!");
            Console.WriteLine("Please select the month you would like to go fishing to return a list of flies " +
                             "that are active.");
            Console.WriteLine("Please press Q to exit the program.");

            var input = Console.ReadLine();
            while (input.ToLower() != "q")
            {
                switch (input.ToLower())
                {
                    case "January":
                        names.Where(Flies => Flies.January).ToList();
                        break;
                    case "February":
                        names.Where(Flies => Flies.February).ToList();
                        break;
                    case "March":
                        names.Where(Flies => Flies.March).ToList();
                        break;
                    case "April":
                        names.Where(Flies => Flies.April).ToList();
                        break;
                    case "May":
                        names.Where(Flies => Flies.May).ToList();
                        break;
                    case "June":
                        names.Where(Flies => Flies.June).ToList();
                        break;
                    case "July":
                        names.Where(Flies => Flies.July).ToList();
                        break;
                    case "August":
                        names.Where(Flies => Flies.August).ToList();
                        break;
                    case "September":
                        names.Where(Flies => Flies.September).ToList();
                        break;
                    case "October":
                        names.Where(Flies => Flies.October).ToList();
                        break;
                    case "November":
                        names.Where(Flies => Flies.November).ToList();
                        break;
                    case "December":
                        names.Where(Flies => Flies.December).ToList();
                        break;
                    default:
                        break;
                }               
                    using (StreamWriter writer = new StreamWriter("Result.txt"))
                    {
                        writer.Write(input);
                    }

                //Console.WriteLine();
            }
        }
    }
}
