using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp
{
    public class FlyFishing
    {
        public string Name { get; set;  }
        public int Size { get; set;  }
        public bool January { get; set; }
        public bool February { get; set; }
        public bool March { get; set; }
        public bool April { get; set; }
        public bool May { get; set; }
        public bool June { get; set; }
        public bool July { get; set; }
        public bool August { get; set; }
        public bool September { get; set; }
        public bool October { get; set; }
        public bool November { get; set; }
        public bool December { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nName: ").Append(Name)
                .Append("\nSize: ").Append(Size)
                .Append("\nJanuary: ").Append(January)
                .Append("\nFebruary: ").Append(February)
                .Append("\nMarch: ").Append(March)
                .Append("\nApril: ").Append(April)
                .Append("\nMay: ").Append(May)
                .Append("\nJune: ").Append(June)
                .Append("\nJuly: ").Append(July)
                .Append("\nAugust: ").Append(August)
                .Append("\nSeptember: ").Append(September)
                .Append("\nOctober: ").Append(October)
                .Append("\nNovember: ").Append(November)
                .Append("\nDecember: ").Append(December);

            return sb.ToString();
        }
    }
}
        
