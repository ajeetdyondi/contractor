namespace Contractor.Models
{
    using System;
    
    public class Salary
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaidOn { get; set; }
        public double GrossAmount { get; set; }
        public double IncomeTax { get; set; }
        public double EmployersNi { get; set; }
        public double EmployeeNi { get; set; }
        public double NetAmount { get; set; }
    }
}
