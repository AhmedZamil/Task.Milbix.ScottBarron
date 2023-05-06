using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Task.Milbix.ScottBarron.DAL;

namespace Task.Milbix.ScottBarron.UnitTest.UnitTest
{
    public class AccountingCalenderGenerator
    {
        [Fact]
        public void Generate_GenerateAccountingCalendarViewModel_PeriodsMustNotBeEmpty()
        {
            //Arrange
            var accountingCalendarGenerator = new AccountingCalendarGenerator();

            DateTime startDate = new DateTime(2020, 7, 2);
            DateTime endDate = new DateTime(2023, 6, 30);

            //Act

            IEnumerable<IPeriod> periods = accountingCalendarGenerator.Generate(startDate, endDate);

            //Assert
            Assert.NotEmpty(periods);
        }

        [Fact]
        public void Generate_GenerateAccountingCalendarViewModel_ReturnTypeMustBeAssignableFormIEnumerableOfIPeriod()
        {
            //Arrange
            var accountingCalendarGenerator = new AccountingCalendarGenerator();

            DateTime startDate = new DateTime(2020, 7, 2);
            DateTime endDate = new DateTime(2023, 6, 30);

            //Act

            var periods = accountingCalendarGenerator.Generate(startDate, endDate);

            //Assert
            Assert.IsAssignableFrom<IEnumerable<IPeriod>>(periods);
        }
    }


}
