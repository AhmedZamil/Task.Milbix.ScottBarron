using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task.Milbix.ScottBarron.DAL;
using Task.Milbix.ScottBarron.Models;
using Task.Milbix.ScottBarron.ViewModel;

namespace Task.Milbix.ScottBarron.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountingCalendarGenerator generator;
        private readonly IPeriodGrouper periodGrouper;

        public HomeController(ILogger<HomeController> logger, IAccountingCalendarGenerator Generator, IPeriodGrouper PeriodGrouper)
        {
            // to demonastrate constructor inj
            _logger = logger;
            generator = Generator;
            periodGrouper = PeriodGrouper;
        }

        // To view 
        public IActionResult Index()
        {
            //IAccountingCalendarGenerator generator = new AccountingCalendarGenerator();
            //IPeriodGrouper periodGrouper = new AccountingPeriodGrouper();

            DateTime startDate = new DateTime(2020, 7, 2);
            DateTime endDate = new DateTime(2023, 6, 30);

            Console.WriteLine($"Accounting Calendar from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
            Console.WriteLine();

            IEnumerable<IPeriod> periods = generator.Generate(startDate, endDate,7);
            var groupedPeriods = periodGrouper.GroupPeriodsByFinancialYear(periods);

            AccountingCalendarViewModel calender = new AccountingCalendarViewModel();
            calender.StartDate = startDate;
            calender.EndDate = endDate;
            List<FinancialYearViewModel> years = new List<FinancialYearViewModel>();

            foreach (var financialYear in groupedPeriods)
            {
                FinancialYearViewModel financialYearModel = new FinancialYearViewModel();
                financialYearModel.StartDate = financialYear.Key.StartDate;
                financialYearModel.EndDate = financialYear.Key.EndDate;
                financialYearModel.DaysInYear = financialYear.Key.DaysInYear;

                List<PeriodViewModel> periodsList = new List<PeriodViewModel>();
                foreach (var period in financialYear.Value)
                {
                    PeriodViewModel periodViewModel = new PeriodViewModel();
                    periodViewModel.StartDate = period.StartDate;
                    periodViewModel.EndDate = period.EndDate;
                    periodViewModel.Number = period.Number;
                    periodsList.Add(periodViewModel);
                   
                }
                financialYearModel.PeriodList = periodsList;
                years.Add(financialYearModel);

            }

            calender.FinancialYears = years;

            return View(calender);
        }

        //To post the input and View
        [HttpPost]
        public IActionResult Index(AccountingCalendarViewModel model)
        {

            DateTime startDate = model.StartDate;
            DateTime endDate = model.EndDate;

            Console.WriteLine($"Accounting Calendar from {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}");
            Console.WriteLine();

            IEnumerable<IPeriod> periods = generator.Generate(startDate, endDate, model.SelectedMonth);
            var groupedPeriods = periodGrouper.GroupPeriodsByFinancialYear(periods);

            AccountingCalendarViewModel calender = new AccountingCalendarViewModel();
            calender.StartDate = startDate;
            calender.EndDate = endDate;
            List<FinancialYearViewModel> years = new List<FinancialYearViewModel>();

            foreach (var financialYear in groupedPeriods)
            {
                FinancialYearViewModel financialYearModel = new FinancialYearViewModel();
                financialYearModel.StartDate = financialYear.Key.StartDate;
                financialYearModel.EndDate = financialYear.Key.EndDate;
                financialYearModel.DaysInYear = financialYear.Key.DaysInYear;

                List<PeriodViewModel> periodsList = new List<PeriodViewModel>();
                foreach (var period in financialYear.Value)
                {
                    PeriodViewModel periodViewModel = new PeriodViewModel();
                    periodViewModel.StartDate = period.StartDate;
                    periodViewModel.EndDate = period.EndDate;
                    periodViewModel.Number = period.Number;
                    periodsList.Add(periodViewModel);

                }
                financialYearModel.PeriodList = periodsList;
                years.Add(financialYearModel);

            }

            calender.FinancialYears = years;

            return View(calender);
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