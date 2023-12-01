using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
		public string? Nombre { get; set; }

		[Required(ErrorMessage = "La dirección es obligatoria")]
		public string? Dirección { get; set; }

		[Required(ErrorMessage = "El Email es obligatorio")]
		[EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "La contraseña es obligatoria")]
		public string? Contraseña { get; set; }

        [ForeignKey("AdminId")]
        public ICollection<AdminDetalle> AdminDetalle { get; set; } = new List<AdminDetalle>();
    }
}