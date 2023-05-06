using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task.Milbix.ScottBarron.DAL;
using Task.Milbix.ScottBarron.Models;

namespace Task.Milbix.ScottBarron.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountingCalendarGenerator generator;
        private readonly IPeriodGrouper periodGrouper;

        public HomeController(ILogger<HomeController> logger, IAccountingCalendarGenerator Generator, IPeriodGrouper PeriodGrouper)
        {
            _logger = logger;
            generator = Generator;
            periodGrouper = PeriodGrouper;
        }

        public IActionResult Index()
        {
            //IAccountingCalendarGenerator generator = new AccountingCalendarGenerator();
            //IPeriodGrouper periodGrouper = new AccountingPeriodGrouper();

            DateTime startDate = new DateTime(2020, 7, 2);
            DateTime endDate = new DateTime(2023, 6, 30);

            Console.WriteLine($"Accounting Calendar from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
            Console.WriteLine();

            IEnumerable<IPeriod> periods = generator.Generate(startDate, endDate);
            var groupedPeriods = periodGrouper.GroupPeriodsByFinancialYear(periods);

            foreach (var financialYear in groupedPeriods)
            {
                Console.WriteLine($"Financial Year: {financialYear.Key.StartDate:yyyy}-{financialYear.Key.EndDate:yyyy}");
                Console.WriteLine($"Days: {financialYear.Key.DaysInYear}");
                Console.WriteLine("Periods:");
                Console.WriteLine();
                Console.WriteLine("Start        End          Period Number");
                foreach (var period in financialYear.Value)
                {
                    Console.WriteLine($"{period.StartDate:yyyy-MM-dd}  {period.EndDate:yyyy-MM-dd}  {period.Number}");
                }
                Console.WriteLine();
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}