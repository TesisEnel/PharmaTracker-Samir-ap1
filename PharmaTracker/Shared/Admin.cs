using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La dirección es obligatorio")]
        public string? Dirección { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string? Teléfono { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string? Contraseña { get; set; }
    }
}
