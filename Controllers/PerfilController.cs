using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Controllers
{
    [Route("api/perfil")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly AppDbContext db;

        public PerfilController(AppDbContext context)
        {
            db = context;
        }

        // GET: api/perfil
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfil>>> GetAll()
        {
            return await db.Perfis.ToListAsync();
        }

        // GET: api/perfil/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Perfil>> GetById(int id)
        {
            var Item = await db.Perfis.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return Item;
        }

        // POST: api/perfil
        [HttpPost]
        public async Task<ActionResult<Perfil>> Post(Perfil item)
        {
            db.Perfis.Add(item);
            await db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = item.Codigo }, item);
        }

        // PUT: api/perfil/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Perfil item)
        {
            if (id != item.Codigo)
            {
                return BadRequest();
            }
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/perfil/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Item = await db.Perfis.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            db.Perfis.Remove(Item);
            await db.SaveChangesAsync();
            return Ok();
        }
    }

}
