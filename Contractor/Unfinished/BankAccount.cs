using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contractor.Models
{
    public class BankAccount
    {
        public virtual string Description { get; set; }
        public virtual string Name { get; set; }
        public virtual string Bank { get; set; }
        public virtual string SortCode { get; set; }
        public virtual string Number { get; set; }
    }
}
