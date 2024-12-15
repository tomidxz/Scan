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
    public class DetallesTraduccionesController : ControllerBase
    {
        private readonly ScanContext _context;

        public DetallesTraduccionesController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/DetallesTraducciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallesTraduccion>>> GetDetallesTraducciones()
        {
            return await _context.DetallesTraducciones.Include(d=>d.EmpleadoEncargado)
                .Include(d=>d.EmpleadoTyper)
                .Include(d=>d.EmpleadoTraductor)
                .Include(d=>d.Manwha).ToListAsync();
        }

        // GET: api/DetallesTraducciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetallesTraduccion>> GetDetallesTraduccion(int id)
        {
            var detallesTraduccion = await _context.DetallesTraducciones.Include(d => d.EmpleadoEncargado)
                .Include(d => d.EmpleadoTyper)
                .Include(d => d.EmpleadoTraductor)
                .Include(d => d.Manwha).FirstOrDefaultAsync(d=>d.Id==id);

            if (detallesTraduccion == null)
            {
                return NotFound();
            }

            return detallesTraduccion;
        }

        // PUT: api/DetallesTraducciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetallesTraduccion(int id, DetallesTraduccion detallesTraduccion)
        {
            if (id != detallesTraduccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(detallesTraduccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetallesTraduccionExists(id))
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

        // POST: api/DetallesTraducciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetallesTraduccion>> PostDetallesTraduccion(DetallesTraduccion detallesTraduccion)
        {
            _context.Attach(detallesTraduccion.EmpleadoCleaner);
            _context.Attach(detallesTraduccion.EmpleadoTyper);
            _context.Attach(detallesTraduccion.EmpleadoTraductor);
            _context.Attach(detallesTraduccion.Manwha);
            _context.DetallesTraducciones.Add(detallesTraduccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetallesTraduccion", new { id = detallesTraduccion.Id }, detallesTraduccion);
        }

        // DELETE: api/DetallesTraducciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetallesTraduccion(int id)
        {
            var detallesTraduccion = await _context.DetallesTraducciones.FindAsync(id);
            if (detallesTraduccion == null)
            {
                return NotFound();
            }

            _context.DetallesTraducciones.Remove(detallesTraduccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetallesTraduccionExists(int id)
        {
            return _context.DetallesTraducciones.Any(e => e.Id == id);
        }
    }
}
