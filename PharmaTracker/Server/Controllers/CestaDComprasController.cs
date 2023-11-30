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
    public class CestaDComprasController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public CestaDComprasController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/CestaDCompras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CestaDCompra>>> GetCestaDCompra()
        {
          if (_context.CestaDCompra == null)
          {
              return NotFound();
          }
            return await _context.CestaDCompra.ToListAsync();
        }

        // GET: api/CestaDCompras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CestaDCompra>> GetCestaDCompra(int id)
        {
          if (_context.CestaDCompra == null)
          {
              return NotFound();
          }
            var cestaDCompra = await _context.CestaDCompra.FindAsync(id);

            if (cestaDCompra == null)
            {
                return NotFound();
            }

            return cestaDCompra;
        }

        // PUT: api/CestaDCompras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCestaDCompra(int id, CestaDCompra cestaDCompra)
        {
            if (id != cestaDCompra.CestaDCompraId)
            {
                return BadRequest();
            }

            _context.Entry(cestaDCompra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CestaDCompraExists(id))
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

        // POST: api/CestaDCompras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CestaDCompra>> PostCestaDCompra(CestaDCompra cestaDCompra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (cestaDCompra.CestaDCompraId <= 0 || !CestaDCompraExists(cestaDCompra.CestaDCompraId))
            {
                _context.CestaDCompra.Add(cestaDCompra);
            }
            await _context.SaveChangesAsync();

            return Ok(cestaDCompra);
        }

// DELETE: api/CestaDCompras/5
[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCestaDCompra(int id)
        {
            if (_context.CestaDCompra == null)
            {
                return NotFound();
            }
            var cestaDCompra = await _context.CestaDCompra.FindAsync(id);
            if (cestaDCompra == null)
            {
                return NotFound();
            }

            _context.CestaDCompra.Remove(cestaDCompra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CestaDCompraExists(int id)
        {
            return (_context.CestaDCompra?.Any(e => e.CestaDCompraId == id)).GetValueOrDefault();
        }
    }
}
