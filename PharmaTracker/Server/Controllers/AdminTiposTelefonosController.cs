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
    public class AdminTiposTelefonosController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public AdminTiposTelefonosController(PharmaTracketContext context)
        {
            _context = context;
        }

        // GET: api/AdminTiposTelefonos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminTiposTelefonos>>> GetAdminTiposTelefonos()
        {
          if (_context.AdminTiposTelefonos == null)
          {
              return NotFound();
          }
            return await _context.AdminTiposTelefonos.ToListAsync();
        }

        // GET: api/AdminTiposTelefonos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminTiposTelefonos>> GetAdminTiposTelefonos(int id)
        {
            var tipo = await _context.AdminTiposTelefonos.FindAsync(id);

            return tipo!;
        }
    }
}
