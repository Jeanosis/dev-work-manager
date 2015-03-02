using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;

namespace Domain.Entities
{
    class FluentDBConfig
    {
        FluentDBConfig()
        {

        }
    }

    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)

                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                  .ConnectionString(
                  @"Server=(local);initial catalog=xxxxx;
		user=xxxxx;password=xxxxx;") // Modify your ConnectionString
                              .ShowSql()
                )
                .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<DevWorkMainProject.Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                                .Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
