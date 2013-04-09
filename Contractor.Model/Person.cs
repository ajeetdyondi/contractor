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
    public class Person
    {
        public virtual int Id { get; private set; }
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual DateTime LastUpdated { get; private set; }

        public virtual Client Client { get; set; }
        public virtual Agency Agency { get; set; }
    }
}
