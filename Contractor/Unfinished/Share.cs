namespace Contractor.Models
{
    using System;

    public class Share : ITimeBound
    {
        public virtual ushort Id { get; protected set; }
        public virtual Person Holder { get; set; }
        public virtual ushort Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
