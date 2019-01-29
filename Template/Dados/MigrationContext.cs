using System;
using System.Data.Entity;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Template.Dados.Entidades;

namespace Template.Dados
{
    public class MigrationContext : DbContext
    {
        public MigrationContext(IConfiguration configuracao)
            : base(ObterConexaoOracle(configuracao["StringsConexao:MigrationContexto"]), true)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        private static OracleConnection ObterConexaoOracle(string stringConexao)
        {
            if (string.IsNullOrEmpty(stringConexao))
                throw new ArgumentException(
                    $"Necessário informar string de conexão para o contexto {nameof(MigrationContext)}");

            return new OracleConnection(stringConexao);
        }
    }
}