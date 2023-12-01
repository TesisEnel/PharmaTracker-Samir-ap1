using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PharmaTracker.Shared
{
	public class Clientes
	{
		[Key]
		public int ClienteId { get; set; }
		[Required(ErrorMessage = "El nombre es obligatorio")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
		public string? Nombre { get; set; }
		[Required(ErrorMessage = "La dirección es obligatoria")]
		public string? Dirección { get; set; }
		[Required(ErrorMessage = "El teléfono es obligatorio")]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe tener 10 dígitos")]
		public string? Teléfono { get; set; }
		[Required(ErrorMessage = "El Email es obligatorio")]
		[EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "La contraseña es obligatoria")]
		public string? Contraseña { get; set; }


	}
}
