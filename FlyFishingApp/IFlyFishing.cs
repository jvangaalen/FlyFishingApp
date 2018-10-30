using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp 
{
   public interface IFlyFishing
   {
        void WriteToFile(string value);
        void ReadFromFile();
   }
}
