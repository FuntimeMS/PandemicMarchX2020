using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePandemicDateApp
{
    public static class PandemicDateTime 
    {
        public static DateTime PandemicStart { get; } = new DateTime(2020, 03, 11);
        public static string GetTodayAsPandemicDate()
        {
            DateTime Today = DateTime.Now;
            return PandemicDateToString(Today);
        }
        public static string PandemicDateToString(DateTime date)
        {
            TimeSpan durationOfPandemic = date.Subtract(PandemicStart);
            string PandemicDateString = $"{ PandemicStart:MMMM} { PandemicStart.Day + durationOfPandemic.Days }, { PandemicStart.Year }";
            return PandemicDateString;
        }
    }
}
