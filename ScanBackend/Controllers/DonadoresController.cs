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
    public class DonadoresController : ControllerBase
    {
        private readonly ScanContext _context;

        public DonadoresController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/Donadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donador>>> GetDonadores([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.Donadores.Where(d => d.Nombre.ToUpper().Contains(filtro.ToUpper())).ToListAsync();
            }

            return await _context.Donadores.ToListAsync();
        }

        // GET: api/Donadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donador>> GetDonador(int id)
        {
            var donador = await _context.Donadores.FindAsync(id);

            if (donador == null)
            {
                return NotFound();
            }

            return donador;
        }

        // PUT: api/Donadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonador(int id, Donador donador)
        {
            if (id != donador.Id)
            {
                return BadRequest();
            }

            _context.Entry(donador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonadorExists(id))
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

        // POST: api/Donadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Donador>> PostDonador(Donador donador)
        {
            _context.Donadores.Add(donador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonador", new { id = donador.Id }, donador);
        }

        // DELETE: api/Donadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonador(int id)
        {
            var donador = await _context.Donadores.FindAsync(id);
            if (donador == null)
            {
                return NotFound();
            }
            donador.Eliminado = true;
            _context.Donadores.Update(donador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonadorExists(int id)
        {
            return _context.Donadores.Any(e => e.Id == id);
        }
    }
}
