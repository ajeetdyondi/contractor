namespace Contractor.Models
{
    using System;

    public class Share
    {
        public virtual short Id { get; protected set; }
        public virtual Person Holder { get; set; }
        public virtual int Quantity { get; set; }
        public virtual DateTime HeldFrom { get; set; }
        public virtual DateTime HeldTo { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
