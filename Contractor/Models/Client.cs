namespace Contractor.Models
{
    using System;
    using System.Collections.Generic;

    public class Client
    {
        public virtual short Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Person> ContactPersons { get; set; }
        public virtual string Email { get; set; }
        public virtual string WorkPhone { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }
		
		public virtual IList<Contract> Contracts { get; set; }

        public Client()
        {
            Addresses = new List<Address>();
            ContactPersons = new List<Person>();
            Contracts = new List<Contract>();
        }
    }
}
