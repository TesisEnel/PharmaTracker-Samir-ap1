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
    public class VendedorTiposTelefonosController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public VendedorTiposTelefonosController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/VendedorTiposTelefonos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendedorTiposTelefonos>>> GetVendedorTiposTelefonos()
        {
          if (_context.VendedorTiposTelefonos == null)
          {
              return NotFound();
          }
          return await _context.VendedorTiposTelefonos.ToListAsync();
        }

        // GET: api/VendedorTiposTelefonos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendedorTiposTelefonos>> GetVendedorTiposTelefonos(int id)
        {
            var tipo = await _context.VendedorTiposTelefonos.FindAsync(id);

            return tipo!;
        }
    }
}
