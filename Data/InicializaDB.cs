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

            #region Usuarios
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
            #endregion
            #region Perfis
            if (context.Perfis.Any())
            {
                return;
            }

            var perfis = new Perfil[]
            {
              new Perfil {Codigo=1, Nome="DIRETORIA" },
              new Perfil {Codigo=2, Nome="GERENTE" },
              new Perfil {Codigo=3, Nome="CAIXA" }
            };

            foreach (Perfil p in perfis)
            {
                context.Perfis.Add(p);
            }

            context.SaveChanges();
            #endregion
            #region Modulos
            if (context.Modulos.Any())
            {
                return;
            }

            var modulos = new Modulo[]
            {
              new Modulo {Codigo="TAB009A", Nome="CADASTRO DE PRODUTOS", Status=true },
              new Modulo {Codigo="TAB001A", Nome="CADASTRO DE CLIENTES", Status=true },
              new Modulo {Codigo="TAB002A", Nome="CADASTRO DE FORNECEDORES", Status=true }
            };

            foreach (Modulo p in modulos)
            {
                context.Modulos.Add(p);
            }

            context.SaveChanges();
            #endregion
        }
    }
}
