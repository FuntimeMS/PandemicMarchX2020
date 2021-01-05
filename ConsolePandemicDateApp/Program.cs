using System;

namespace ConsolePandemicDateApp
{
    class Program
    {
        public static DateTime PandemicStart { get; } = new DateTime(2020, 03, 11);

        public static void Main()
        {
            Console.WriteLine("Hello World!");

            DateTime Today = DateTime.Now;
            TimeSpan durationOfPandemic = Today.Subtract(PandemicStart);

            Console.WriteLine($"Today is { Today:MMMM dd, yyyy}");
            Console.WriteLine($"Pandemic has been our life since { PandemicStart }");
            Console.WriteLine($"That was { durationOfPandemic.Days } days ago");

            Console.WriteLine($"Today's Pandemic Date is: { PandemicDateTime.PandemicDateToString(Today) }");

            DateTime test1 = new DateTime(2020, 03, 30, 15, 0, 0);
            Console.WriteLine($"Testing: Pandemic Date for { test1 } is: { PandemicDateTime.PandemicDateToString(test1) }");
            test1 = new DateTime(2020, 04, 30, 15, 0, 0);
            Console.WriteLine($"Testing: Pandemic Date for { test1 } is: { PandemicDateTime.PandemicDateToString(test1) }");
            test1 = new DateTime(2020, 05, 31, 15, 0, 0);
            Console.WriteLine($"Testing: Pandemic Date for { test1 } is: { PandemicDateTime.PandemicDateToString(test1) }");
            test1 = new DateTime(2020, 06, 30, 15, 0, 0);
            Console.WriteLine($"Testing: Pandemic Date for { test1 } is: { PandemicDateTime.PandemicDateToString(test1) }");
            test1 = new DateTime(2020, 07, 31, 15, 0, 0);
            Console.WriteLine($"Testing: Pandemic Date for { test1 } is: { PandemicDateTime.PandemicDateToString(test1) }");
        }
    }
}
