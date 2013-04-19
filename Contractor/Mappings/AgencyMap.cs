namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    class AgencyMap : ClassMap<Agency>
    {
        public AgencyMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Email);
            Map(x => x.WorkPhone);
            HasManyToMany(x => x.Addresses)
                .Cascade.All()
                .Table("AgencyAddress");
            // Contracts
            // ContactPersons

            Map(x => x.LastUpdated).Generated.Always();
        }
    }
}
