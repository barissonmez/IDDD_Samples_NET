using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;

namespace SaaSOvation.Common.Port.Adapters.Persistence
{
    public class DataSource
    {
        public DataSource(string connectionString, string providerName)
        {
            this.providerFactory = DbProviderFactories.GetFactory(providerName);
            this.connectionString = connectionString;
        }

        readonly DbProviderFactory providerFactory;
        readonly string connectionString;

        public DbConnection CreateOpenConnection()
        {
            var conn = this.providerFactory.CreateConnection();
            conn.ConnectionString = this.connectionString;
            conn.Open();
            return conn;
        }
    }
}
