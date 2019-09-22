using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Mapping
{
    public class UsuarioPerfilMap
    {
        public UsuarioPerfilMap(EntityTypeBuilder<UsuarioPerfil> entityBuilder)
        {
            entityBuilder.HasKey(bc => new { bc.UsuarioID, bc.PerfilID });

            entityBuilder.Property(x => x.UsuarioID).HasColumnName("ID_USUARIO").IsRequired();
            entityBuilder.Property(x => x.PerfilID).HasColumnName("ID_PERFIL").IsRequired();

            entityBuilder.HasOne(bc => bc.Usuario).WithMany(b => b.Perfis).HasForeignKey(bc => bc.UsuarioID);
            entityBuilder.HasOne(bc => bc.Perfil).WithMany(b => b.Usuarios).HasForeignKey(bc => bc.PerfilID);
        }
    }
}
