// -----------------------------------------------------------------------
// <copyright file="Client.cs" company="">
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
    public class Client
    {
        public virtual int Id { get; private set; }
        public virtual String Code { get; set; }
        public virtual String Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual DateTime LastUpdated { get; private set; }

public virtual ICollection<Contract> Contracts { get; set; }
    }
}
