using System;

namespace Contractor.Models
{
    public class Company
    {
        public virtual String Number { get; set; }
        public virtual String Name { get; set; }
        public virtual DateTime IncorporatedOn { get; set; }
        public virtual Address Address { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
/*
        public virtual IList<Person> Directors { get; set; }
        public virtual IList<Tax> Taxes { get; set; }
        public virtual IList<BankAccount> Accounts { get; set; }
 
        public Company()
        {
            x = new List<?>();
        }
 */
    }
}
