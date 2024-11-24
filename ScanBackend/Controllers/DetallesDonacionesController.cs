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
    public class DetallesDonacionesController : ControllerBase
    {
        private readonly ScanContext _context;

        public DetallesDonacionesController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/DetallesDonaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallesDonacion>>> GetDetallesDonaciones()
        {
            return await _context.DetallesDonaciones.ToListAsync();
        }

        // GET: api/DetallesDonaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetallesDonacion>> GetDetallesDonacion(int id)
        {
            var detallesDonacion = await _context.DetallesDonaciones.FindAsync(id);

            if (detallesDonacion == null)
            {
                return NotFound();
            }

            return detallesDonacion;
        }

        // PUT: api/DetallesDonaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetallesDonacion(int id, DetallesDonacion detallesDonacion)
        {
            if (id != detallesDonacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(detallesDonacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetallesDonacionExists(id))
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

        // POST: api/DetallesDonaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetallesDonacion>> PostDetallesDonacion(DetallesDonacion detallesDonacion)
        {
            _context.DetallesDonaciones.Add(detallesDonacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetallesDonacion", new { id = detallesDonacion.Id }, detallesDonacion);
        }

        // DELETE: api/DetallesDonaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetallesDonacion(int id)
        {
            var detallesDonacion = await _context.DetallesDonaciones.FindAsync(id);
            if (detallesDonacion == null)
            {
                return NotFound();
            }

            _context.DetallesDonaciones.Remove(detallesDonacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetallesDonacionExists(int id)
        {
            return _context.DetallesDonaciones.Any(e => e.Id == id);
        }
    }
}
