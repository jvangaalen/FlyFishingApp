using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFishingApp 
{
   public class FlyMap : ClassMap<FlyFishing>
   {
        public FlyMap()
        {
            Map(x => x.Name).Name("Name");
            Map(x => x.Size).Name("Size");

            Map(x => x.January).Name("January");
            Map(x => x.February).Name("February");
            Map(x => x.March).Name("March");
            Map(x => x.April).Name("April");
            Map(x => x.May).Name("May");
            Map(x => x.June).Name("June");
            Map(x => x.July).Name("July");
            Map(x => x.August).Name("August");
            Map(x => x.September).Name("September");
            Map(x => x.October).Name("October");
            Map(x => x.November).Name("November");
            Map(x => x.December).Name("December");



        }
   }
}
