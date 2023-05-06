using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public abstract class PeriodBase : IPeriod
    {
        public int Number { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        protected PeriodBase(int number, DateTime startDate, DateTime endDate)
        {
            Number = number;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
