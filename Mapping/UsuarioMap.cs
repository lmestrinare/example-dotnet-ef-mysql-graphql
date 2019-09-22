using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Mapping
{
    public class UsuarioMap
    {
        public UsuarioMap(EntityTypeBuilder<Usuario> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Codigo);

            entityBuilder.Property(x => x.Codigo).HasColumnName("ID_USUARIO").IsRequired();
            entityBuilder.Property(x => x.Nome).HasColumnName("NOME_USUARIO").IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Login).HasColumnName("LOGIN_USUARIO").IsRequired().HasMaxLength(15);
            entityBuilder.Property(x => x.Senha).HasColumnName("SENHA_USUARIO").IsRequired().HasMaxLength(15);
            entityBuilder.Property(x => x.Status).HasColumnName("STATUS_USUARIO").IsRequired();

            entityBuilder.HasMany(c => c.Perfis).WithOne(e => e.Usuario);
        }
    }
}
