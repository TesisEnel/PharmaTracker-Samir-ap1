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
    public class CarritoComprasController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public CarritoComprasController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/CarritoCompras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarritoCompra>>> GetCestaDCompra()
        {
          if (_context.CestaDCompra == null)
          {
              return NotFound();
          }
            return await _context.CestaDCompra.ToListAsync();
        }

        // GET: api/CarritoCompras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarritoCompra>> GetCarritoCompra(int id)
        {
          if (_context.CestaDCompra == null)
          {
              return NotFound();
          }
            var carritoCompra = await _context.CestaDCompra.FindAsync(id);

            if (carritoCompra == null)
            {
                return NotFound();
            }

            return carritoCompra;
        }

        // PUT: api/CarritoCompras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarritoCompra(int id, CarritoCompra carritoCompra)
        {
            if (id != carritoCompra.CarritoCompraId)
            {
                return BadRequest();
            }

            _context.Entry(carritoCompra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarritoCompraExists(id))
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

        // POST: api/CarritoCompras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarritoCompra>> PostCarritoCompra(CarritoCompra carritoCompra)
        {
          if (_context.CestaDCompra == null)
          {
              return Problem("Entity set 'PharmaTracketContext.CestaDCompra'  is null.");
          }
            _context.CestaDCompra.Add(carritoCompra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarritoCompra", new { id = carritoCompra.CarritoCompraId }, carritoCompra);
        }

        // DELETE: api/CarritoCompras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarritoCompra(int id)
        {
            if (_context.CestaDCompra == null)
            {
                return NotFound();
            }
            var carritoCompra = await _context.CestaDCompra.FindAsync(id);
            if (carritoCompra == null)
            {
                return NotFound();
            }

            _context.CestaDCompra.Remove(carritoCompra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarritoCompraExists(int id)
        {
            return (_context.CestaDCompra?.Any(e => e.CarritoCompraId == id)).GetValueOrDefault();
        }
    }
}
