using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Models
{
    public class Perfil
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public List<UsuarioPerfil> Usuarios { get; set; }
        public List<PerfilModulo> Modulos { get; set; }
    }
}
