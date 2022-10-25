using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cuentasPorPagarApi.Context;
using cuentasPorPagarApi.Entities;

namespace cuentasPorPagarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosDeCuentasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MovimientosDeCuentasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MovimientosDeCuentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovimientosDeCuentas>>> GetMovimientosDeCuentas()
        {
            return await _context.MovimientosDeCuentas.ToListAsync();
        }

        // GET: api/MovimientosDeCuentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovimientosDeCuentas>> GetMovimientosDeCuentas(int id)
        {
            var movimientosDeCuentas = await _context.MovimientosDeCuentas.FindAsync(id);

            if (movimientosDeCuentas == null)
            {
                return NotFound();
            }

            return movimientosDeCuentas;
        }

        // PUT: api/MovimientosDeCuentas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimientosDeCuentas(int id, MovimientosDeCuentas movimientosDeCuentas)
        {
            if (id != movimientosDeCuentas.IdPago)
            {
                return BadRequest();
            }

            _context.Entry(movimientosDeCuentas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimientosDeCuentasExists(id))
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

        // POST: api/MovimientosDeCuentas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovimientosDeCuentas>> PostMovimientosDeCuentas(MovimientosDeCuentas movimientosDeCuentas)
        {
            _context.MovimientosDeCuentas.Add(movimientosDeCuentas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimientosDeCuentas", new { id = movimientosDeCuentas.IdPago }, movimientosDeCuentas);
        }

        // DELETE: api/MovimientosDeCuentas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimientosDeCuentas(int id)
        {
            var movimientosDeCuentas = await _context.MovimientosDeCuentas.FindAsync(id);
            if (movimientosDeCuentas == null)
            {
                return NotFound();
            }

            _context.MovimientosDeCuentas.Remove(movimientosDeCuentas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovimientosDeCuentasExists(int id)
        {
            return _context.MovimientosDeCuentas.Any(e => e.IdPago == id);
        }
    }
}
