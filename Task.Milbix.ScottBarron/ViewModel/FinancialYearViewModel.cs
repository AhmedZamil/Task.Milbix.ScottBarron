using Task.Milbix.ScottBarron.DAL;

namespace Task.Milbix.ScottBarron.ViewModel
{
    public class FinancialYearViewModel
    {
        public int DaysInYear { get; set; }
        public int Number { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<PeriodViewModel> PeriodList { get; set; }
    }
}
