using System.Data.Entity;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.EntityFramework;

namespace Template.Dados
{
    public class OracleDbConfig : DbConfiguration
    {
        public static readonly DbConfiguration Instancia = new OracleDbConfig();

        public OracleDbConfig()
        {
            SetDefaultConnectionFactory(new OracleConnectionFactory());
            SetProviderServices("Oracle.ManagedDataAccess.Client", EFOracleProviderServices.Instance);
            SetProviderFactory("Oracle.ManagedDataAccess.Client", new OracleClientFactory());
            SetDatabaseInitializer<HrContext>(null);

            // SetDatabaseInitializer(new DropCreateDatabaseAlways<MigrationContext>());

            AddInterceptor(new EntityMonitorInterceptor());
        }
    }
}
