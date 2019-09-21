using example_dotnet_ef_mysql_graphql.Mapping;
using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UsuarioMap(modelBuilder.Entity<Usuario>());
            new PerfilMap(modelBuilder.Entity<Perfil>());
            new ModuloMap(modelBuilder.Entity<Modulo>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
    }
}
