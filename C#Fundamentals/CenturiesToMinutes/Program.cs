using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Century = 100 years = 36524 days = 876576 hours = 52594560 minutes.
            //Read a number from the console ( represents the centuries ) and convert it to the formula on top.
            Console.Write("Enter the centuries you want to convert : ");
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries*100;
            long days = (long) (years * 365.2422); // A tropical year has 365.2422 days 
            long hours = centuries * 876576;
            long minutes = centuries * 52594560;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",centuries,years,days,hours,minutes);
            Console.ReadLine();
        }
    }
}
