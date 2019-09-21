using example_dotnet_ef_mysql_graphql.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Types
{
    public class UsuarioType : ObjectGraphType<Usuario>
        {
        public UsuarioType()
        {
            Name = "Usuario";
            Field(x => x.Codigo).Description("Código");
            Field(x => x.Nome).Description("Nome");
            Field(x => x.Login).Description("Login");
            Field(x => x.Senha).Description("Senha");
            Field(x => x.Status).Description("Status");
        }
    }
}
