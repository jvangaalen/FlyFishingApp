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

            Map(x => x.January).Name("January")
                .ConvertUsing(row =>
                {
                    // Get the data in the row
                    var data = row.GetField("January");

                    //// If the data value is NULL, set the value to actual null
                    if (data == "yes")
                    {
                        return true;
                    }
                    // Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.February).Name("February")
                .ConvertUsing(row =>
                {
                    // Get the data in the row
                    var data = row.GetField("February");

                // If the data value is NULL, set the value to actual null
                if (data == "yes")
                {
                    return true;
                }
                    {
                    return false;
                    }
                });
            Map(x => x.March).Name("March")
                .ConvertUsing(row =>
                {                  
                    //Get the data in the row
                    var data = row.GetField("March");

                    if (data == "yes")
                    {
                        return true;
                    }
                    
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.April).Name("April")
                .ConvertUsing(row =>
                {

                    // Get the data in the row
                    var data = row.GetField("April");

                    
                    if (data == "yes")
                    {
                        return true;
                    }
                    
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.May).Name("May")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                    var data = row.GetField("May");


                    if (data == "yes")
                    {
                        return true;
                    }
                   
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.June).Name("June")
                .ConvertUsing(row =>
                { 
                    
                    // Get the data in the row
                    var data = row.GetField("June");


                    if (data == "yes")
                    {
                        return true;
                    }
                    
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.July).Name("July")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                 var data = row.GetField("July");


                if (data == "yes")
                {
                    return true;
                }
               // Otherwise, parse the string into an int
                    else
                    {
                    return false;
                    }
                });
            Map(x => x.August).Name("August")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                    var data = row.GetField("August");


                    if (data == "yes")
                    {
                        return true;
                    }
                    //Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.September).Name("September")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                    var data = row.GetField("September");

                    // If the data value is NULL, set the value to actual null
                    if (data == "yes")
                    {
                        return true;
                    }
                    //Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.October).Name("October")
                .ConvertUsing(row =>
                {
                               
                    // Get the data in the row
                    var data = row.GetField("October");


                    if (data == "yes")
                    {
                        return true;
                    }
                    //Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.November).Name("November")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                    var data = row.GetField("November");


                    if (data == "yes")
                    {
                        return true;
                    }
                    //Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
            Map(x => x.December).Name("December")
                .ConvertUsing(row =>
                {
                    
                    // Get the data in the row
                    var data = row.GetField("December");


                    if (data == "yes")
                    {
                        return true;
                    }
                    //Otherwise, parse the string into an int
                    else
                    {
                        return false;
                    }
                });
        }
   }
}
