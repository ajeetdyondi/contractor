using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contractor.Models
{
    public class Tax
    {
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string Reference { get; set; }
        public virtual DateTime RegisteredFrom { get; set; }
    }
}
