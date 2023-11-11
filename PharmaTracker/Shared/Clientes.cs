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
		public string Nombre { get; set; }
		[Required(ErrorMessage = "La dirección es obligatorio")]
		public string Direccion { get; set; }
		[Required(ErrorMessage = "El teléfono es obligatorio")]
		public string Telefono { get; set; }
		[Required(ErrorMessage = "El Email es obligatorio")]
		public string Email { get; set; }

	}
}
