using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext db;

        public UsuarioController(AppDbContext context)
        {
            db = context;
        }

        // GET: api/usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAll()
        {
            return await db.Usuarios.ToListAsync();
        }

        // GET: api/usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetById(int id)
        {
            var Item = await db.Usuarios.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return Item;
        }

        // POST: api/usuario
        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario item)
        {
            db.Usuarios.Add(item);
            await db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = item.Codigo }, item);
        }

        // PUT: api/usuario/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario item)
        {
            if (id != item.Codigo)
            {
                return BadRequest();
            }
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Item = await db.Usuarios.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            db.Usuarios.Remove(Item);
            await db.SaveChangesAsync();
            return Ok();
        }
    }

}
