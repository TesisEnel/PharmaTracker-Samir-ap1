using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmaTracker.Shared;

namespace PharmaTracker.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            SesionDTO sesionDTO = new SesionDTO();
            if (login.Correo == "admin@gmail.com" && login.Clave == "admin")
            {
                sesionDTO.Nombre = "admin";
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Administrador";
            }
            else if (login.Correo == "vendedor@gmail.com" && login.Clave == "vendedor")
            {
                sesionDTO.Nombre = "vendedor";
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Vendedor";
            }
            else if (login.Correo == "cliente@gmail.com" && login.Clave == "cliente")
            {
                sesionDTO.Nombre = "cliente";
                sesionDTO.Correo = login.Correo;
                sesionDTO.Rol = "Cliente";
            }
            else
            {
                return BadRequest("Usuario o contraseña incorrecta");
            }
            return StatusCode(StatusCodes.Status200OK, sesionDTO);
        }
    }
}
