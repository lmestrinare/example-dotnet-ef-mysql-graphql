using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Types;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace example_dotnet_ef_mysql_graphql.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(AppDbContext db)
        {

            //Field<ListGraphType<UsuarioType>>("usuarios",
            //    arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "codigo" }),
            //    resolve: context => {
            //        int? id = context.GetArgument<int>("codigo");
            //        if (id == null)
            //        {
            //            var usuarios = db.Usuarios;
            //            return usuarios;
            //        } else
            //        {
            //            var usuarios = db.Usuarios.FindAsync(id);
            //            return usuarios;
            //        }
            //    });

            Field<ListGraphType<UsuarioType>>(
                name: "usuarios",
                resolve: context => {
                    var usuarios = db.Usuarios.Include(a => a.Perfis);
                    return usuarios;
                });

            Field<UsuarioType>(
                name: "usuario",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => {
                    var id = context.GetArgument<int>("id");
                    var usuarios = db.Usuarios.FirstOrDefault(i => i.Codigo == id); ;
                    return usuarios;
                });

            /*
            Field<UsuarioType>("usuarios", 
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "codigo", Description = "Codigo" }), 
                resolve: context => db.Usuarios.FindAsync(context.GetArgument<int>("codigo"))
            );

            Field<ListGraphType<UsuarioType>>("perfis", resolve: context =>
            {
                var usuariosperfis = db.UsuariosPerfis;
                return usuariosperfis;
            });

            Field<ListGraphType<ModuloType>>("modulos", resolve: context =>
            {
                var modulos = db.Modulos;
                return modulos;
            });
            */

        }
    }
}