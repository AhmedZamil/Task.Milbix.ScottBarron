using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public class FinancialYear : FinancialYearBase
    {
        public FinancialYear(int year, int daysInYear)
            : base(0, new DateTime(year - 1, 7, 1), new DateTime(year, 6, 30), daysInYear)
        {
        }
    }
}
