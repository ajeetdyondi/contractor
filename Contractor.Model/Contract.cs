// -----------------------------------------------------------------------
// <copyright file="Contract.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Contractor.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Contract
    {
        public virtual int Id { get; private set; }
        public virtual String Name { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Agency Agency { get; set; }
        public virtual Client Client { get; set; }
        public virtual IEnumerable<Schedule> Schedules { get; set; }
        public virtual DateTime LastUpdated { get; private set; }
    }
}
