// -----------------------------------------------------------------------
// <copyright file="Agency.cs" company="">
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
    public class Agency
    {
        public virtual int Id { get; private set; }
        public virtual String Name { get; set; }

        // @SCD
        public virtual IEnumerable<Address> Addresses { get; set; }

        public virtual IEnumerable<Person> ContactPersons { get; set; }
        public virtual String Email { get; set; }
        public virtual String WorkPhone { get; set; }
        public virtual DateTime LastUpdated { get; private set; }
		
		public virtual ICollection<Contract> Contracts { get; set; }
    }
}
