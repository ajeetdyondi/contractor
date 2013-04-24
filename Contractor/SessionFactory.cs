using System;
using System.Configuration;
using Contractor.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Contractor
{
    public static class SessionFactory
    {
        private static ISessionFactory _instance;

        public static ISessionFactory Instance
        {
            get { return _instance ?? (_instance = CreateSessionFactory()); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var config = Fluently.Configure()
                           .Database(MySQLConfiguration.Standard.ConnectionString(ConfigurationManager.AppSettings["ConnectionString"]))
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entity>())
                           .BuildConfiguration();

            if (Boolean.Parse(ConfigurationManager.AppSettings["GenerateSchema"]))
            {
                SchemaExport schema = new SchemaExport(config);
                if (Boolean.Parse(ConfigurationManager.AppSettings["OutputToSql"]))
                {
                    schema.SetOutputFile(ConfigurationManager.AppSettings["OutputSqlFile"]);
                }
                schema.Execute(true, true, false);
            }

            return config.BuildSessionFactory();
        }
    }
}
