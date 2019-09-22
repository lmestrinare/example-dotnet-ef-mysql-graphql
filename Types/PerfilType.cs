using example_dotnet_ef_mysql_graphql.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Types
{
    public class PerfilType : ObjectGraphType<Perfil>
    {
        public PerfilType()
        {
            Name = "Perfil";
            Field(x => x.Codigo, type: typeof(IdGraphType)).Description("Código do Perfil");
            Field(x => x.Nome).Description("Nome do Perfil");

            Field<ListGraphType<UsuarioPerfilType>>("usuarios");
            Field<ListGraphType<PerfilModuloType>>("modulos");
        }
    }
}
