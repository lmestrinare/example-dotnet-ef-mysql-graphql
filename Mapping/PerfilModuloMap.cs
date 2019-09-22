using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Mapping
{
    public class PerfilModuloMap
    {
        public PerfilModuloMap(EntityTypeBuilder<PerfilModulo> entityBuilder)
        {
            entityBuilder.HasKey(bc => new { bc.ModuloID, bc.PerfilID });

            entityBuilder.Property(x => x.ModuloID).HasColumnName("ID_MODULO").IsRequired();
            entityBuilder.Property(x => x.PerfilID).HasColumnName("ID_PERFIL").IsRequired();

            entityBuilder.HasOne(bc => bc.Modulo).WithMany(b => b.Perfis).HasForeignKey(bc => bc.ModuloID);
            entityBuilder.HasOne(bc => bc.Perfil).WithMany(b => b.Modulos).HasForeignKey(bc => bc.PerfilID);
        }
    }
}
