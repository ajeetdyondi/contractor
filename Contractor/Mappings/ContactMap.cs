namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("Contact");
            Id(x => x.Id).GeneratedBy.Identity();
            References(x => x.Entity).Column("EntityId").ForeignKey("FK_Contact_Entity").Not.Nullable();
            Map(x => x.Email);
            Map(x => x.BillingEmail);
            Map(x => x.Telephone);
            Map(x => x.Mobile);
            References(x => x.Address).Column("AddressId").ForeignKey("FK_Contact_Address").Not.Nullable().Cascade.All();
            Map(x => x.StartDate).Not.Nullable().CustomSqlType("Date");
            Map(x => x.EndDate).CustomSqlType("Date");
            Map(x => x.LastUpdated).Generated.Always().ReadOnly().CustomSqlType("TIMESTAMP");
        }
    }
}
