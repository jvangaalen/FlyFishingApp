using CsvHelper.Configuration.Attributes;
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
        public string Size { get; set;  }
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

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("\nName: ").Append(Name)
        //        .Append("\nSize: ").Append(Size)
        //        .Append("\nJanuary: ").Append(january)
        //        .Append("\nFebruary: ").Append(february)
        //        .Append("\nMarch: ").Append(march)
        //        .Append("\nApril: ").Append(april)
        //        .Append("\nMay: ").Append(may)
        //        .Append("\nJune: ").Append(june)
        //        .Append("\nJuly: ").Append(july)
        //        .Append("\nAugust: ").Append(august)
        //        .Append("\nSeptember: ").Append(september)
        //        .Append("\nOctober: ").Append(october)
        //        .Append("\nNovember: ").Append(november)
        //        .Append("\nDecember: ").Append(december);

        //    return sb.ToString();
        //}
    }
}
        
