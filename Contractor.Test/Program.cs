namespace Contractor.Test
{
    using System;
    using Models;
    using log4net;

    public class Program
    {
        private static ILog Logger = LogManager.GetLogger(typeof(Program));

        public static void Main(string[] args)
        {
            Logger.Debug("Test");
            Logger.Error("Test");
            Logger.Fatal("Test");
            Logger.Info("Test");
            Logger.Warn("Test");
            var sessionFactory = SessionFactory.Instance;

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Address address1 = new Address
                        {
                            Line1 = "18 Apartment XX",
                            Line2 = "London Street",
                            City = "London",
                            PostCode = "ABC1 4EF",
                            Country = "UK"
                        };

                    Address address2 = new Address
                    {
                        Line1 = "18 Apartment XX",
                        City = "London",
                        PostCode = "ABC1 4EF",
                        Country = "UK"
                    };

                    session.SaveOrUpdate(address2);

                    session.SaveOrUpdate(address1);

                    Agency agency = new Agency {Name = "Agency 1", Person = "John Doe"};
                    
                    Contact info1 = new Contact { Address = address1, Email = "first@efgh.com", StartDate = new DateTime(2012, 12, 01), EndDate = new DateTime(2012, 12, 31), Entity = agency };
                    Contact info2 = new Contact { Address = address2, Email = "second@efgh.com", StartDate = new DateTime(2013, 01, 01), EndDate = new DateTime(2013, 04, 01), Entity = agency };
                    Contact info3 = new Contact { Address = address2, Email = "third@efgh.com", StartDate = new DateTime(2013, 04, 02), Entity = agency };

                    agency.Contacts.Add(info2);
                    agency.Contacts.Add(info1);
                    agency.Contacts.Add(info3);

                    session.SaveOrUpdate(agency);

                    transaction.Commit();
                }
            }
            using (var session = sessionFactory.OpenSession())
            {
                var x = session.QueryOver<Agency>().List();
                var y = x[0].Contacts.Count;
                var z = x[0].Contacts;
            }
        }
    }
}
