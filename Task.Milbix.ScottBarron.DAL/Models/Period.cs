using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public class Period : PeriodBase
    {
        public Period(int number, DateTime startDate, DateTime endDate)
            : base(number, startDate, endDate)
        {
        }
    }

}
