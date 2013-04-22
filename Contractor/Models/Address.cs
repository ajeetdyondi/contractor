namespace Contractor.Models
{
    using System;

    public class Address
    {
        public virtual Byte Id { get; protected set; }
        public virtual String Description { get; set; }
        public virtual String Line1 { get; set; }
        public virtual String Line2 { get; set; }
        public virtual String Line3 { get; set; }
        public virtual String City { get; set; }
        public virtual String PostCode { get; set; }
        public virtual String County { get; set; }
        public virtual String Country { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
