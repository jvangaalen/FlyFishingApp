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
                    return row.January ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("January");

                    //// If the data value is NULL, set the value to actual null
                    //if (data == "no")
                    //{
                    //    return null;
                    //}
                    //// Otherwise, parse the string into an int
                    //else
                    //{
                    //    return bool.Parse(data);
                    //}
                });
            Map(x => x.February).Name("February")
                .ConvertUsing(row =>
                {
                    return row.February ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("February");

                    // If the data value is NULL, set the value to actual null
                   // if (data == "no")
                    //{
                       // return null;
                    //}
                    // Otherwise, parse the string into an int
                   // else
                    //{
                        //return bool.Parse(data);
                    //}
                });
            Map(x => x.March).Name("March")
                .ConvertUsing(row =>
                {
                    return row.March ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("March");

                    // If the data value is NULL, set the value to actual null
                   // if (data == "no")
                    //{
                       // return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                   // {
                   //     return bool.Parse(data);
                   // }
                });
            Map(x => x.April).Name("April")
                .ConvertUsing(row =>
                {
                    return row.April ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("April");

                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                   // {
                        //return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                    //{
                       // return bool.Parse(data);
                    //}
                });
            Map(x => x.May).Name("May")
                .ConvertUsing(row =>
                {
                    return row.May ? "yes" : "no";
                    // Get the data in the row
                   // var data = row.GetField("May");
                    
                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                    //{
                       // return null;
                    //}
                    // Otherwise, parse the string into an int
                   // else
                   // {
                        //return bool.Parse(data);
                    //}
                });
            Map(x => x.June).Name("June")
                .ConvertUsing(row =>
                { 
                    return row.June ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("June");

                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                   // {
                      //  return null;
                   // }
                    // Otherwise, parse the string into an int
                    //else
                    //{
                        //return bool.Parse(data);
                   // }
                });
            Map(x => x.July).Name("July")
                .ConvertUsing(row =>
                {
                    return row.July ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("July");

                    // If the data value is NULL, set the value to actual null
                   // if (data == "no")
                    //{
                        //return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                   // {
                        //return bool.Parse(data);
                    //}
                });
            Map(x => x.August).Name("August")
                .ConvertUsing(row =>
                {
                    return row.August ? "yes" : "no";
                    // Get the data in the row
                   // var data = row.GetField("August");

                    // If the data value is NULL, set the value to actual null
                   //if (data == "no")
                  //  {
                      //  return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                   // {
                        //return bool.Parse(data);
                   // }
                });
            Map(x => x.September).Name("September")
                .ConvertUsing(row =>
                {
                    return row.September ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("September");

                    // If the data value is NULL, set the value to actual null
                   // if (data == "no")
                    //{
                      //  return null;
                   // }
                    // Otherwise, parse the string into an int
                    //else
                   // {
                      //  return bool.Parse(data);
                    //}
                });
            Map(x => x.October).Name("October")
                .ConvertUsing(row =>
                {
                    return row.October ? "yes" : "no";            
                    // Get the data in the row
                   // var data = row.GetField("October");

                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                   // {
                       // return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                    //{
                        //return bool.Parse(data);
                    //}
                });
            Map(x => x.November).Name("November")
                .ConvertUsing(row =>
                {
                    return row.November ? "yes" : "no";
                    // Get the data in the row
                    //var data = row.GetField("November");

                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                    //{
                       // return null;
                    //}
                    // Otherwise, parse the string into an int
                    //else
                   // {
                       // return bool.Parse(data);
                    //}
                });
            Map(x => x.December).Name("December")
                .ConvertUsing(row =>
                {
                    return row.December ? "yes" : "no";
                    // Get the data in the row
                   // var data = row.GetField("December");

                    // If the data value is NULL, set the value to actual null
                    //if (data == "no")
                    //{
                       // return null;
                   // }
                    // Otherwise, parse the string into an int
                    //else
                    //{
                        //return bool.Parse(data);
                    //}
                });
        }
   }
}
