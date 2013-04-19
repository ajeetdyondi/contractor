namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Line1);
            Map(x => x.Line2);
            Map(x => x.Line3);
            Map(x => x.City);
            Map(x => x.PostCode);
            Map(x => x.County);
            Map(x => x.Country);
            Map(x => x.LastUpdated).Generated.Always();
        }
    }
}
