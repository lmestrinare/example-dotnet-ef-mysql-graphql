using example_dotnet_ef_mysql_graphql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Data
{
    public class InicializaDB
    {
        public static void Inicializa(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Usuarios.Any())
            {
                return;
            }

            var usuarios = new Usuario[]
            {
              new Usuario {Codigo=1, Nome="LUCIO", Login="LUCIO", Senha="123", Status=true },
              new Usuario {Codigo=2, Nome="MARCO", Login="MARCO", Senha="123", Status=true },
              new Usuario {Codigo=3, Nome="EDUARDO", Login="EDUARDO", Senha="123", Status=true }
            };

            foreach (Usuario p in usuarios)
            {
                context.Usuarios.Add(p);
            }

            context.SaveChanges();
        }
    }
}
