using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Types;
using GraphQL.Types;

namespace example_dotnet_ef_mysql_graphql.Queries
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(AppDbContext db)
        {

            Field<ListGraphType<UsuarioType>>("usuarios", resolve: context =>
                {
                    var usuarios = db.Usuarios;
                    return usuarios;
                });

        }
    }
}