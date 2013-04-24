namespace Contractor.Models
{
    using System;

    public class Share
    {
        public virtual ushort Id { get; protected set; }
        public virtual Person Holder { get; set; }
        public virtual ushort Quantity { get; set; }
        public virtual DateTime HeldFrom { get; set; }
        public virtual DateTime HeldTo { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
