namespace Contractor.Models
{
    using System;

    public class Person
    {
        public virtual short Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string NationalInsuranceNo { get; set; }
        public virtual string UniqueTaxReference { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
    }
}
