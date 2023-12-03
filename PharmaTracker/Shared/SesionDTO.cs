using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PharmaTracker.Shared
{
    public class SesionDTO
    {
        [Key]
        public int SesionId { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Rol { get; set; }
	}
}
