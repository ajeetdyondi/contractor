namespace Contractor.Models
{
    using System;
    
    public class Dividend
    {
        public TimeSpan Id { get; set; }
        public DateTime Date { get; set; }
        public double NetAmount { get; set; }
        public double TaxCredit { get; set; }
        public double GrossAmount { get; set; }
    }
}
