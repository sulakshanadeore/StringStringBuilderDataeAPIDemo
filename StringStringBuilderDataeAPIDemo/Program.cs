using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilderDataeAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Date");
            //DateTime dt = new DateTime();
            //dt = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Day=  " + dt.Day);
            //Console.WriteLine("Month=  " + dt.Month);
            //Console.WriteLine("Year=" + dt.Year);
            //Console.WriteLine("Hour = " + dt.Hour);
            //Console.WriteLine("Add 2 Days " +dt.AddDays(2));
            //Console.WriteLine("Day of year "  + dt.DayOfYear);//236
            //Console.WriteLine("Local time = " + dt.ToLocalTime());
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.WriteLine("Long Date =" + dt1.ToLongDateString());
            Console.WriteLine("Short Date=" + dt1.ToShortDateString());
            Console.WriteLine("Long Time =" + dt1.ToLongTimeString());
            Console.WriteLine("Short Time =" + dt1.ToShortTimeString());
            Console.WriteLine("Add 2 Days " + dt1.AddDays(-2));

            Console.WriteLine("--------------------------------");
            DateTime dt2 = new DateTime(2022, 08, 23);
           TimeSpan time_sp= dt1.Subtract(dt2);
            Console.WriteLine(time_sp);
            Console.WriteLine("----------------------------------");

            DateTime utcTime=dt1.ToUniversalTime();
                        Console.WriteLine(utcTime);
            Console.WriteLine("----------------");
            Console.WriteLine("Is Leap Year");
            bool isLeapYear=DateTime.IsLeapYear(2008);
            Console.WriteLine(isLeapYear);
            Console.WriteLine("----------------------");
            Console.WriteLine(DateTime.Today);
            Console.WriteLine("------------------------");
            
            Console.ReadLine();
                



        }
    }
}
