using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Milbix.ScottBarron.DAL;

namespace Task.Milbix.ScottBarron.UnitTest.UnitTest
{
    public class GroupPeriodsByFinancialYear
    {
        [Fact]
        public void AccountingPeriodGrouper_GroupFinancialPerioInGroip_ReturnTypeMustBeAssignableFormDictionaryByKeyIFinancialYear()
        {
            //Arrange
            var accountingCalendarGenerator = new AccountingCalendarGenerator();
            AccountingPeriodGrouper accountingPeriodGrouper = new AccountingPeriodGrouper();

            DateTime startDate = new DateTime(2020, 7, 2);
            DateTime endDate = new DateTime(2023, 6, 30);

            //Act

            var periods = accountingCalendarGenerator.Generate(startDate, endDate);
            var groupedPeriods = accountingPeriodGrouper.GroupPeriodsByFinancialYear(periods);
            //Assert
            Assert.IsAssignableFrom<Dictionary<IFinancialYear, List<IPeriod>>>(groupedPeriods);
        }
    }
}
