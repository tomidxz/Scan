using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScanService.DataContext;
using ScanServices.Models;

namespace ScanBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrigenesController : ControllerBase
    {
        private readonly ScanContext _context;

        public OrigenesController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/Origenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Origen>>> GetOrigenes()
        {
            return await _context.Origenes.ToListAsync();
        }

        // GET: api/Origenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Origen>> GetOrigen(int id)
        {
            var origen = await _context.Origenes.FindAsync(id);

            if (origen == null)
            {
                return NotFound();
            }

            return origen;
        }

        // PUT: api/Origenes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigen(int id, Origen origen)
        {
            if (id != origen.Id)
            {
                return BadRequest();
            }

            _context.Entry(origen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrigenExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Origenes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Origen>> PostOrigen(Origen origen)
        {
            _context.Origenes.Add(origen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrigen", new { id = origen.Id }, origen);
        }

        // DELETE: api/Origenes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrigen(int id)
        {
            var origen = await _context.Origenes.FindAsync(id);
            if (origen == null)
            {
                return NotFound();
            }

            _context.Origenes.Remove(origen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrigenExists(int id)
        {
            return _context.Origenes.Any(e => e.Id == id);
        }
    }
}
