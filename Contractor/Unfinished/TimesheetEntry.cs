namespace Contractor.Models
{
    using System;
    
    public class TimesheetEntry
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double Hours { get; set; }
        public string Comments { get; set; }
    
        public virtual Schedule Schedule { get; set; }

        // Bank Holiday = Date
        // morning, noon, extra?
    }
}
