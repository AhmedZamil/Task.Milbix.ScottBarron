using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Milbix.ScottBarron.DAL
{
    public class AccountingPeriodGrouper : IPeriodGrouper
    {
        public Dictionary<IFinancialYear, List<IPeriod>> GroupPeriodsByFinancialYear(IEnumerable<IPeriod> periods)
        {
            Dictionary<IFinancialYear, List<IPeriod>> groupedPeriods = new Dictionary<IFinancialYear, List<IPeriod>>();
            IFinancialYear currentFinancialYear = null;
            List<IPeriod> currentPeriods = new List<IPeriod>();

            foreach (var period in periods)
            {
                if (period is IFinancialYear)
                {
                    currentFinancialYear = (IFinancialYear)period;
                    if (currentFinancialYear != null && currentFinancialYear.EndDate >= new DateTime(2020, 6, 30))
                    {

                        groupedPeriods.Add(currentFinancialYear, currentPeriods);
                    }

                    if (currentFinancialYear == null && (currentPeriods != null && currentPeriods.Any()))
                    {
                        currentFinancialYear = (IFinancialYear)period;
                        groupedPeriods.Add(currentFinancialYear, currentPeriods);
                        currentPeriods = new List<IPeriod>();
                    }


                    //if (currentPeriods != null && currentPeriods.Any() )
                    //{
                    //    currentPeriods = new List<IPeriod>();
                    //}

                    currentPeriods = new List<IPeriod>();


                }
                else
                {
                    if (currentPeriods == null)
                    {
                        currentPeriods = new List<IPeriod>();
                    }
                    currentPeriods.Add(period);
                }
            }

            // Add the last financial year and its associated periods
            //if (currentFinancialYear != null)
            //{
            //    groupedPeriods.Add(currentFinancialYear, currentPeriods);
            //}

            return groupedPeriods;
        }
    }
}
