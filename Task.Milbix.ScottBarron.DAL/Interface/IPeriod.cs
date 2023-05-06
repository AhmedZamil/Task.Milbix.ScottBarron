using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public interface IPeriod
    {
        int Number { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
