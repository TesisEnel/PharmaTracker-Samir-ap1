using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmaTracker.Server.DAL;
using PharmaTracker.Shared;

namespace PharmaTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaPagoController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public TarjetaPagoController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/TarjetaPago
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarjetaPago>>> GetTarjetaPago()
        {
          if (_context.TarjetaPago == null)
          {
              return NotFound();
          }
            return await _context.TarjetaPago.ToListAsync();
        }

        // GET: api/TarjetaPago/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarjetaPago>> GetTarjetaPago(int id)
        {
          if (_context.TarjetaPago == null)
          {
              return NotFound();
          }
            var tarjetaPago = await _context.TarjetaPago.FindAsync(id);

            if (tarjetaPago == null)
            {
                return NotFound();
            }

            return tarjetaPago;
        }

        // PUT: api/TarjetaPago/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarjetaPago(int id, TarjetaPago tarjetaPago)
        {
            if (id != tarjetaPago.TarjetaPagoId)
            {
                return BadRequest();
            }

            _context.Entry(tarjetaPago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarjetaPagoExists(id))
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

        // POST: api/TarjetaPago
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TarjetaPago>> PostTarjetaPago(TarjetaPago tarjetaPago)
        {
            if (tarjetaPago.TarjetaPagoId <= 0 || !TarjetaPagoExists(tarjetaPago.TarjetaPagoId))
            {
                _context.TarjetaPago.Add(tarjetaPago);
            }

            await _context.SaveChangesAsync();

            return Ok(tarjetaPago);
        }

        // DELETE: api/TarjetaPago/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarjetaPago(int id)
        {
            if (_context.TarjetaPago == null)
            {
                return NotFound();
            }
            var tarjetaPago = await _context.TarjetaPago.FindAsync(id);
            if (tarjetaPago == null)
            {
                return NotFound();
            }

            _context.TarjetaPago.Remove(tarjetaPago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarjetaPagoExists(int id)
        {
            return (_context.TarjetaPago?.Any(e => e.TarjetaPagoId == id)).GetValueOrDefault();
        }
    }
}
