namespace Contractor.Models
{
    using System;

    public class Entity : IContactable
    {
        public virtual ushort Id { get; protected set; }
        public virtual String Name { get; set; }
        public virtual String Person { get; set; }
        public virtual AuditableList<Contact> Contacts { get; set; }
        public virtual DateTime LastUpdated { get; protected set; }

        public Entity()
        {
            Contacts = new AuditableList<Contact>();
        }
    }
}
