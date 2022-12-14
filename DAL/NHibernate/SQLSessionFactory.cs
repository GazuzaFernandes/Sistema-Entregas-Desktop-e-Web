


using DAL.Entities.Logistica;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace DAL.NHibertnate
{
    public enum BancoDados
    {
        SqlServer = 1,
        PostgressSql = 2
    }
    public class SQLSessionFactory
    {
        public static BancoDados banco { get; set; }
        //POSTGRES
        private static string ConexaoPostgressSql = @"Server= localhost;Port=5432;User Id=postgres;Password=q1s2e3f4t5;Database=RbDesktop;";
        
        //MS SQL SERVER
        private static string ConexaoSqlServer = @"Data Source=.\SQLExpress;Initial Catalog=RB;Persist Security Info=True;User ID=RBCOMERCIO;Password=gazuza;";

        public static ISessionFactory session;
        public static ISessionFactory CreateSession()
        {
            if (session != null)
                return session;
            try
            {
                IPersistenceConfigurer dbConfig = MsSqlConfiguration.MsSql2012.ConnectionString(ConexaoSqlServer);
                if (banco == BancoDados.PostgressSql)
                    dbConfig = PostgreSQLConfiguration.Standard.ConnectionString(ConexaoPostgressSql);
                var mapConfig = Fluently.Configure().Database(dbConfig).Mappings(c =>
                    c.FluentMappings.AddFromAssemblyOf<Usuario>());

                session = mapConfig.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return session;
        }

        public static ISession StartSession()
        {
            banco = BancoDados.PostgressSql;
            return CreateSession().OpenSession();
        }
    }
}

