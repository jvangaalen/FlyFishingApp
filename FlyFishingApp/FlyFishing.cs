using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp
{
    public class FlyFishing : IFlyFishing
    {
        private readonly string _filePath;

        public FlyFishing(string path)
        {
            _filePath = path;
        }

    public string ReadFromFile()
    }
    {
        string flyContents = "";

        using (StreamReader reader = new StreamReader(_filePath))
        {
            flyContents = reader.ReadToEnd();
        }

        return flyContents;
    }

    public void WriteToFile(string value)
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            writer.Write(value);
        }
    }
} 
