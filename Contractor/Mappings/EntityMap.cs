﻿using FluentNHibernate;

namespace Contractor.Mappings
{
    using Models;
    using FluentNHibernate.Mapping;

    public class EntityMap : ClassMap<Entity>
    {
        public EntityMap()
        {
            Table("Entity");
            Id(x => x.Id).GeneratedBy.Identity();
            DiscriminateSubClassesOnColumn("Type", (byte)0);
            Map(x => x.Name).Not.Nullable().Unique();

            Component(x => x.Contacts,
                      m =>
                      m.HasMany<Contact>(Reveal.Member<AuditableList<Contact>>("InnerList"))
                       .KeyColumn("EntityId")
                       .Cascade.All());

            Map(x => x.Person);
            Map(x => x.LastUpdated).Generated.Always().ReadOnly().CustomSqlType("TIMESTAMP");
        }
    }
}