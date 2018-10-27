using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp
{
    public class FlyFishingReader
    {
        public int Id { get; set; }
        public string Fly { get; set; }
        public int Size { get; set; }
        public string Month { get; set; }
        public bool CanUseFly { get; set; }

        public ICollection<FlyFishingResult> FlyFishingResults { get; set; }
    }

    public class FlyFishingResult
    {
        public string Fly { get; set; }
        public int Size { get; set; }
        public string Month { get; set; }
    }

}
