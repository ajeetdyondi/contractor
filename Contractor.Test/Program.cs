namespace Contractor.Test
{
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
                    Contact info1 = new Contact { Address = address1, Email = "abcd@efgh.com", Entity = agency };
                    agency.Contacts.AddAsCurrent(info1);

                    Client client = new Client { Name = "Client 1", Person = "Jane Doe" };
                    Contact info2 = new Contact { Address = address2, Email = "abcd@efgh.com", Entity = client };
                    client.Contacts.AddAsCurrent(info2);

                    session.SaveOrUpdate(client);

                    session.SaveOrUpdate(agency);

                    transaction.Commit();
                }
            }
        }
    }
}
