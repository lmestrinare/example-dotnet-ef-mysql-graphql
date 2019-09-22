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
            Field(x => x.Codigo, type: typeof(IdGraphType)).Description("Código do Usuário");
            Field(x => x.Nome).Description("Nome do Usuário");
            Field(x => x.Login).Description("Login do Usuário");
            Field(x => x.Senha).Description("Senha do Usuário");
            Field(x => x.Status).Description("Status do Usuário");
            Field(x => x.Perfis).Description("Perfis do Usuário");

            Field<ListGraphType<UsuarioPerfilType>>("perfis");
        }
    }
}
