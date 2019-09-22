using example_dotnet_ef_mysql_graphql.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Types
{
    public class UsuarioPerfilType : ObjectGraphType<UsuarioPerfil>
    {
        public UsuarioPerfilType()
        {
            Name = "UsuarioPerfil";

            Field(x => x.UsuarioID);
            Field(x => x.PerfilID);
        }
    }
}
