using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Queries;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {

        private readonly AppDbContext _db;

        public GraphQLController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();
            var schema = new Schema() { Query = new EatMoreQuery(_db) };
            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}

