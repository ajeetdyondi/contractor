namespace Contractor.Models
{
    using System;
    using System.Collections.Generic;

    public class Client
    {
        public virtual Byte Id { get; protected set; }
        public virtual String Code { get; set; }
        public virtual String Name { get; set; }
        public virtual String ManagerName { get; set; }
        public virtual Address Address { get; set; }
        public virtual String Email { get; set; }
        public virtual String Phone { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }

/*
        public virtual IList<Contract> Contracts { get; set; }
        
        public Agency()
        {
            Contracts = new List<Contract>();
        }
*/
    }
}
