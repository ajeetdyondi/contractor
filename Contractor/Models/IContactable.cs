namespace Contractor.Models
{
    public interface IContactable
    {
        AuditableList<Contact> Contacts { get; set; }
    }
}
