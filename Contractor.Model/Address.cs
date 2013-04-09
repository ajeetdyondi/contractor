// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="">
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
    public class Address
    {
        public virtual int Id { get; private set; }
        public virtual String Description { get; set; }
        public virtual String Line1 { get; set; }
        public virtual String Line2 { get; set; }
        public virtual String Line3 { get; set; }
        public virtual String City { get; set; }
        public virtual String PostCode { get; set; }
        public virtual String County { get; set; }
        public virtual String Country { get; set; }
        public virtual DateTime LastUpdated { get; private set; }
		
		        public virtual Client Client { get; set; }
        public virtual Agency Agency { get; set; }
    }
}
