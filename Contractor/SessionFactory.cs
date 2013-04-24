namespace Contractor
{
    using System;
    using System.Configuration;
    using Contractor.Models;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Tool.hbm2ddl;

    public static class SessionFactory
    {
        private static ISessionFactory _instance;

        public static ISessionFactory Instance
        {
            get { return _instance ?? (_instance = CreateSessionFactory()); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var mySqlConfig = MySQLConfiguration.Standard;
            if (Boolean.Parse(ConfigurationManager.AppSettings["ShowSQL"]))
            {
                mySqlConfig.ShowSql();
            }
            mySqlConfig.ConnectionString(ConfigurationManager.AppSettings["ConnectionString"]);

            var config = Fluently.Configure()
                           .Database(mySqlConfig)
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entity>())
                           .BuildConfiguration();

            if (Boolean.Parse(ConfigurationManager.AppSettings["GenerateSchema"]))
            {
                SchemaExport schema = new SchemaExport(config);
                if (Boolean.Parse(ConfigurationManager.AppSettings["OutputDDLToFile"]))
                {
                    schema.SetOutputFile(ConfigurationManager.AppSettings["OutputDDLFilePath"]);
                }
                schema.Execute(true, true, false);
            }

            return config.BuildSessionFactory();
        }
    }
}
