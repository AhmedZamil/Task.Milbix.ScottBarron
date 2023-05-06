using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public abstract class FinancialYearBase : PeriodBase, IFinancialYear
    {
        public int DaysInYear { get; }

        protected FinancialYearBase(int number, DateTime startDate, DateTime endDate, int daysInYear)
            : base(number, startDate, endDate)
        {
            DaysInYear = daysInYear;
        }
    }
}
