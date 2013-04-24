namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class ClientMap : SubclassMap<Client>
    {
        public ClientMap()
        {
            DiscriminatorValue(3);
        }
    }
}
