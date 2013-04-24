namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class CompanyMap : SubclassMap<Company>
    {
        public CompanyMap()
        {
            DiscriminatorValue(1);
        }
    }
}
