using System;
namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared my variables
            int year, count = 0, serialNumber = 1;
            //To print out present year
            Console.Write("Current Year is: ");
            //This displays today's date year
            DateTime now = DateTime.Today;
            Console.WriteLine(now.ToString("yyyy"));
            year = int.Parse(now.ToString("yyyy"));
            //Loop 20 times
            while (count < 20)
            {
                year++;

                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    Console.WriteLine(serialNumber + " Year " + year + " is a leap year");
                    count++;
                    serialNumber++;
                }
            }
        }
    }
}
