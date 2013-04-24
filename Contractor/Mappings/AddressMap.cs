namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("Address");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Line1).Not.Nullable();
            Map(x => x.Line2);
            Map(x => x.Line3);
            Map(x => x.City).Not.Nullable();
            Map(x => x.PostCode).Not.Nullable();
            Map(x => x.County);
            Map(x => x.Country).Not.Nullable();
            Map(x => x.LastUpdated).Generated.Always().ReadOnly().CustomSqlType("TIMESTAMP");
        }
    }
}
