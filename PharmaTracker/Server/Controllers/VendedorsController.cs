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
    public class VendedorsController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public VendedorsController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/Vendedors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendedor>>> GetVendedor()
        {
          if (_context.Vendedor == null)
          {
              return NotFound();
          }
            return await _context.Vendedor.ToListAsync();
        }

        // GET: api/Vendedors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendedor>> GetVendedor(int id)
        {
            if (_context.Vendedor == null)
            {
                return NotFound();
            }

            var vendedor = await _context.Vendedor
                .Include(a => a.VendedorDetalle)
                .Where(a => a.VendedorId == id)
                .FirstOrDefaultAsync();

            if (vendedor == null)
            {
                return NotFound();
            }

            return vendedor;
        }

        // PUT: api/Vendedors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendedor(int id, Vendedor vendedor)
        {
            if (id != vendedor.VendedorId)
            {
                return BadRequest();
            }

            _context.Entry(vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(id))
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

        // POST: api/Vendedors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vendedor>> PostVendedor(Vendedor vendedor)
        {
            if (!VendedorExists(vendedor.VendedorId))
                _context.Vendedor.Add(vendedor);
            else
                _context.Vendedor.Update(vendedor);

            await _context.SaveChangesAsync();

            return Ok(vendedor);
        }

        // DELETE: api/Vendedors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendedor(int id)
        {
            if (_context.Vendedor == null)
            {
                return NotFound();
            }
            var vendedor = await _context.Vendedor.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }

            _context.Vendedor.Remove(vendedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendedorExists(int id)
        {
            return (_context.Vendedor?.Any(e => e.VendedorId == id)).GetValueOrDefault();
        }
    }
}
