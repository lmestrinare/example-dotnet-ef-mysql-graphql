using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Mapping
{
    public class ModuloMap
    {
        public ModuloMap(EntityTypeBuilder<Modulo> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Codigo);

            entityBuilder.Property(x => x.Codigo).HasColumnName("ID_MODULO").IsRequired();
            entityBuilder.Property(x => x.Nome).HasColumnName("NOME_MODULO").IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Status).HasColumnName("STATUS_MODULO").IsRequired();
        }
    }
}
