using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Models
{
    public class UsuarioPerfil
    {
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public int PerfilID { get; set; }
        public Perfil Perfil { get; set; }
    }
}
