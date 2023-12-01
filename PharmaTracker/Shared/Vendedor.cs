using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaTracker.Shared
{
	public class Vendedor
	{
		[Key]
		public int VendedorId { get; set; }
		[Required(ErrorMessage = "El nombre es obligatorio")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
		public string? Nombre { get; set; }
		[Required(ErrorMessage = "La dirección es obligatorio")]
		public string? Dirección { get; set; }
		[Required(ErrorMessage = "El Email es obligatorio")]
		[EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida")]
		public string? Email { get; set; }
		[Required(ErrorMessage ="La contraseña es obligatoria")]
		public string? Contraseña { get; set; }

        [ForeignKey("VendedorId")]
        public ICollection<VendedorDetalle> VendedorDetalle { get; set; } = new List<VendedorDetalle>();
    }
}
