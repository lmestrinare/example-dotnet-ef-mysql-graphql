using example_dotnet_ef_mysql_graphql.Data;
using example_dotnet_ef_mysql_graphql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace example_dotnet_ef_mysql_graphql.Controllers
{
    [Route("api/modulo")]
    [ApiController]
    public class ModuloController : ControllerBase
    {
        private readonly AppDbContext db;

        public ModuloController(AppDbContext context)
        {
            db = context;
        }

        // GET: api/modulo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modulo>>> GetAll()
        {
            return await db.Modulos.ToListAsync();
        }

        // GET: api/modulo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modulo>> GetById(int id)
        {
            var Item = await db.Modulos.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return Item;
        }

        // POST: api/modulo
        [HttpPost]
        public async Task<ActionResult<Modulo>> Post(Modulo item)
        {
            db.Modulos.Add(item);
            await db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = item.Codigo }, item);
        }

        // PUT: api/modulo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Modulo item)
        {
            if (id != item.Codigo)
            {
                return BadRequest();
            }
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/modulo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Item = await db.Modulos.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            db.Modulos.Remove(Item);
            await db.SaveChangesAsync();
            return Ok();
        }
    }

}
