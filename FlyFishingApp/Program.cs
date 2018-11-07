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
            List<XName> names;
            using (var streamReader = new StreamReader("../../HatchChart.csv"))
            using (var reader = new CsvReader(streamReader))
            {
                reader.Configuration.RegisterClassMap<FlyMap>();
                names = reader.GetRecords<XName>().ToList();
            }
        }
    }
}
