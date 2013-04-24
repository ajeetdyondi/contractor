﻿namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class AgencyMap : SubclassMap<Agency>
    {
        public AgencyMap()
        {
            DiscriminatorValue(2);
        }
    }
}
