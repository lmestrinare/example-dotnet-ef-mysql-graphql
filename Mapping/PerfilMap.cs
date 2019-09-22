using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Mapping
{
    public class PerfilMap
    {
        public PerfilMap(EntityTypeBuilder<Perfil> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Codigo);

            entityBuilder.Property(x => x.Codigo).HasColumnName("ID_PERFIL").IsRequired();
            entityBuilder.Property(x => x.Nome).HasColumnName("NOME_PERFIL").IsRequired().HasMaxLength(50);

            entityBuilder.HasMany(c => c.Modulos).WithOne(e => e.Perfil);
        }
    }
}
