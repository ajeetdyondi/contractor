namespace Contractor.Models
{
    using System;
    
    public class Invoice
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double GrossAmount { get; set; }
        public double NetAmount { get; set; }
        public double Vat { get; set; }
        public DateTime? PaidOn { get; set; }
    
        public virtual Schedule Schedule { get; set; }

        // days, net , vat, gross, paidon, personId
    }
}
