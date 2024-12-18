﻿using System;
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
    public class ManwhasController : ControllerBase
    {
        private readonly ScanContext _context;

        public ManwhasController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/Manwhas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manwha>>> GetManwhas([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.Manwhas.Where(d => d.Nombre.ToUpper().Contains(filtro.ToUpper())).ToListAsync();
            }

            return await _context.Manwhas.ToListAsync();
        }

        // GET: api/Manwhas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manwha>> GetManwha(int id)
        {
            var manwha = await _context.Manwhas.FindAsync(id);

            if (manwha == null)
            {
                return NotFound();
            }

            return manwha;
        }

        //creamos un metodo de los manwhas populares
        [HttpGet("getPopular")]
        public async Task<ActionResult<IEnumerable<Manwha>>> GetManwhasPopulares()
        {
            return await _context.Manwhas.Where(p => p.Popular).ToListAsync();
        }

        //creamos un metodo de los manwhas favoritos
        [HttpGet("getFavoritos")]
        public async Task<ActionResult<IEnumerable<Manwha>>> GetManwhasFavoritos()
        {
            return await _context.Manwhas.Where(p => p.Favoritos).ToListAsync();
        }

        // PUT: api/Manwhas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManwha(int id, Manwha manwha)
        {
            if (id != manwha.Id)
            {
                return BadRequest();
            }

            _context.Entry(manwha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManwhaExists(id))
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

        // POST: api/Manwhas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Manwha>> PostManwha(Manwha manwha)
        {
            _context.Manwhas.Add(manwha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetManwha", new { id = manwha.Id }, manwha);
        }

        // DELETE: api/Manwhas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManwha(int id)
        {
            var manwha = await _context.Manwhas.FindAsync(id);
            if (manwha == null)
            {
                return NotFound();
            }

            manwha.Eliminado = true;
            _context.Manwhas.Update(manwha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ManwhaExists(int id)
        {
            return _context.Manwhas.Any(e => e.Id == id);
        }
    }
}
