using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PandemicMarchX2020.Pages
{
    public class IndexModel : PageModel
    {
        public static DateTime PandemicStart { get; } = new DateTime(2020, 03, 11);
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

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
