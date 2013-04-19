using System.Collections.Generic;
using Contractor.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Contractor.Test
{
    class Program
    {
        private const string DbFile = @"C:\Repositories\Contractor\Database\Contractor.sdf";

        static void Main(string[] args)
        {
            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Address address = new Address
                        {
                            Name = "Address 1",
                            Line1 = "18 Apartment XX",
                            Line2 = "London Street",
                            City = "London",
                            PostCode = "ABC1 4EF",
                            Country = "UK"
                        };

                    Address address2 = new Address
                    {
                        Name = "Address 2",
                        Line1 = "18 Apartment XX",
                        Line2 = "London Street",
                        City = "London",
                        PostCode = "ABC1 4EF",
                        Country = "UK"
                    };

                    Agency agency = new Agency { Name = "Agency 1", Email = "abc@agency1.com", WorkPhone = "1234-567-890", Addresses = new List<Address> { address } };
                    Agency agency2 = new Agency { Name = "Agency 2", Email = "abc@agency1.com", WorkPhone = "1234-567-890", Addresses = new List<Address> { address2 } };
                    session.SaveOrUpdate(agency);
                    session.SaveOrUpdate(agency2);
                    transaction.Commit();
                }
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(MySQLConfiguration.Standard.)
              .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Address>())
              .BuildSessionFactory();
        }
    }
}
