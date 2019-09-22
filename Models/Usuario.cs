using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using example_dotnet_ef_mysql_graphql.Types;
using GraphQL.Types;

namespace example_dotnet_ef_mysql_graphql.Models
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public List<UsuarioPerfil> Perfis { get; set; }
    }
}
