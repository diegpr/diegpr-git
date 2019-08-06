using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TheProject.API.Model.Entities;

namespace TheProject.API.Model.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public AppDbContext(){}

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<FuncionarioCargo> FuncionarioCargo { get; set; }
        public DbSet<FuncionarioEndereco> FuncionarioEndereco { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<ProjetoFuncionario> ProjetoFuncionario { get; set; }
        public DbSet<SegmentoCliente> SegmentoCliente { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoLogradouro> TipoLogradouro { get; set; }
        public DbSet<UF> UF { get; set; }
    }

    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder().Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connString = config.GetConnectionString("TheProjectConnString") ??
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BecaDB;Integrated Security=True";
            builder.UseSqlServer(connString);
            return new AppDbContext(builder.Options);
        }
    }
}