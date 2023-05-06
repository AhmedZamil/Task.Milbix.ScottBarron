using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public interface IAccountingCalendarGenerator
    {
        IEnumerable<IPeriod> Generate(DateTime startDate, DateTime endDate);
    }
}
