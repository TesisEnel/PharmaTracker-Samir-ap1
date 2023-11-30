using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmaTracker.Shared;
using PharmaTracker.Server.DAL;
using Microsoft.EntityFrameworkCore;

namespace PharmaTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly PharmaTracketContext _context;

        public UsuarioController(PharmaTracketContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            SesionDTO sesionDTO = new SesionDTO();

            var adminFound = await _context.Admin.FirstOrDefaultAsync(x => x.Email == login.Correo && x.Contraseña == login.Clave);

            if (adminFound != null && adminFound.Email == login.Correo && adminFound.Contraseña == login.Clave)

            {
                sesionDTO.Nombre = adminFound!.Nombre!;
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Administrador";

                return StatusCode(StatusCodes.Status200OK, sesionDTO);
            }

            /*else if (userFound != null && userFound.Email == login.Correo && userFound.Contraseña != login.Clave)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña incorrecta");
            }*/

            var vendedorFound = await _context.Vendedor.FirstOrDefaultAsync(x => x.Email == login.Correo);

            if (vendedorFound != null && vendedorFound.Email == login.Correo && vendedorFound.Contraseña == login.Clave)
            {
                sesionDTO.Nombre = vendedorFound.Nombre;
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Vendedor";

                return StatusCode(StatusCodes.Status200OK, sesionDTO);
            }

            /* else if (vendedorFound != null && vendedorFound.Email == login.Correo && vendedorFound.Contraseña != login.Clave)
             {
                 StatusCode(StatusCodes.Status401Unauthorized, "Contraseña incorrecta");
             }*/

            var clienteFound = await _context.Clientes.FirstOrDefaultAsync(x => x.Email == login.Correo && x.Contraseña == login.Clave);

            if (clienteFound != null && clienteFound.Email == login.Correo && clienteFound.Contraseña == login.Clave)
            {
                sesionDTO.Nombre = clienteFound.Nombre;
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Cliente";

                return StatusCode(StatusCodes.Status200OK, sesionDTO);
            }

            /*else if (clienteFound != null && clienteFound.Email == login.Correo && clienteFound.Contraseña != login.Clave)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña incorrecta");
            }*/
/*
            else if (clienteFound == null || vendedorFound == null || adminFound == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Usuario no encontrado");
            }
            else if (login.Clave != adminFound.Contraseña || login.Clave != vendedorFound.Contraseña || login.Clave != clienteFound.Contraseña)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña no encontrada");
            }*/

            /*            else if (clienteFound == null && vendedorFound == null && userFound == null)
                        {
                            return StatusCode(StatusCodes.Status401Unauthorized, "Contraseña no encontrada");
                        }*/

            return StatusCode(StatusCodes.Status200OK, sesionDTO);
        }
    }
}
