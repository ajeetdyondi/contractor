namespace Contractor.Models
{
    using System;
    using System.Collections.Generic;

    public class Contract
    {
        public virtual short Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Agency Agency { get; set; }
        public virtual Client Client { get; set; }
        // public virtual IList<Schedule> Schedules { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
