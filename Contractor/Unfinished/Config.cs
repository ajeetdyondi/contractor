using System;

namespace Contractor.Models
{
    public class Config : ITimeBound
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        // VAT Rate, Corp Tax Rate, Tax Credit %
    }
}
