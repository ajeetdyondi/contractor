using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contractor.Models
{
    public class Company
    {
        public virtual string Name { get; set; }
        public virtual string Number { get; set; }
        public virtual DateTime StartedOn { get; set; }
        public virtual IList<Person> Directors { get; set; }
        public virtual IList<Tax> Taxes { get; set; }
        public virtual IList<BankAccount> Accounts { get; set; }
        public virtual Address Address { get; set; }
        public virtual string Email { get; set; }
        public virtual string WorkPhone { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }

    }
}
