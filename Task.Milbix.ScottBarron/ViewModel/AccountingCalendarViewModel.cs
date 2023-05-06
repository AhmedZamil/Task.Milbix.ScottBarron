using Task.Milbix.ScottBarron.DAL;

namespace Task.Milbix.ScottBarron.ViewModel
{
    public class AccountingCalendarViewModel
    {
        public int Number { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SelectedMonth { get; set; }

        public List<FinancialYearViewModel> FinancialYears { get; set; }
    }
}
