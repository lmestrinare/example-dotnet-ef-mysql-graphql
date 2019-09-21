using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Models
{
    public class Modulo
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }

        //public ICollection<Perfil> Perfis { get; set; }
        //public ICollection<Usuario> Usuarios { get; set; }
    }
}
