using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public class AccountingCalendarGenerator : IAccountingCalendarGenerator
    {
        public IEnumerable<IPeriod> Generate(DateTime startDate, DateTime endDate, int financialYearStartMonth = 7)
        {
            // I have taken it from the starting of the month
            var currentPeriodStart = new DateTime(startDate.Year, startDate.Month, 1);
            var currentPeriodNumber = (startDate.Month + (12 - financialYearStartMonth)) % 12 + 1; // calculate period number if financialYearStartMonth = 7 (July = 1, June = 12)
            var currentFinancialYear = startDate.Month <= (12 - financialYearStartMonth)+1 ? startDate.Year : startDate.Year + 1;
            var daysInCurrentYear = DateTime.IsLeapYear(currentFinancialYear) ? 366 : 365; // calculate number of days in current financial year

            while (currentPeriodStart <= endDate)
            {
                var currentPeriodEnd = currentPeriodStart.AddMonths(1).AddDays(-1); // last day of current period
                yield return new Period(currentPeriodNumber, currentPeriodStart, currentPeriodEnd); // yield current period
                currentPeriodStart = currentPeriodStart.AddMonths(1); // advance to next period
                currentPeriodNumber = (currentPeriodNumber % 12) + 1; // advance period number, wrapping around to 1 after 12
                if (currentPeriodNumber == 1) // end of financial year
                {
                    yield return new FinancialYear(currentFinancialYear, daysInCurrentYear); // yield financial year
                    currentFinancialYear++;
                    daysInCurrentYear = DateTime.IsLeapYear(currentFinancialYear) ? 366 : 365; // calculate number of days in new financial year
                }

                /* NOTE : Tried to demonastrate the yields ( just to be smart).
                
                Why should I use the yield keyword? The yield keyword can do a state-full iteration sans the need of creating a temporary collection.
                 * In other words, when using the "yield return" statement inside an iterator,
                 * you need not create a temporary collection to store data before it returned.*/
            }
        }
    }
}
