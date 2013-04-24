namespace Contractor.Models
{
    using System;

    public class Contact : ITimeBound
    {
        public virtual ushort Id { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Address Address { get; set; }
        public virtual String Email { get; set; }
        public virtual String BillingEmail { get; set; }
        public virtual String Telephone { get; set; }
        public virtual String Mobile { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime LastUpdated { get; set; }
    }
}
