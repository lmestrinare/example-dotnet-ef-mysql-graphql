using example_dotnet_ef_mysql_graphql.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Types
{
    public class ModuloType : ObjectGraphType<Modulo>
    {
        public ModuloType()
        {
            Name = "Modulo";
            Field(x => x.Codigo, type: typeof(IdGraphType)).Description("Código do Módulo");
            Field(x => x.Nome).Description("Nome do Módulo");
            Field(x => x.Status).Description("Status do Módulo");

            Field<ListGraphType<PerfilModuloType>>("perfis");
        }
    }
}
