using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Models
{
    public class PerfilModulo
    {
        public int PerfilID { get; set; }
        public Perfil Perfil { get; set; }
        public string ModuloID { get; set; }
        public Modulo Modulo { get; set; }
    }
}
