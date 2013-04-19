namespace Contractor.Models
{
    using System;

    public class Address
    {
        public virtual short Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Line1 { get; set; }
        public virtual string Line2 { get; set; }
        public virtual string Line3 { get; set; }
        public virtual string City { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string County { get; set; }
        public virtual string Country { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
