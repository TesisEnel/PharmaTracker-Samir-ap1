using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
	public class AdminDetalle
	{
		[Key]
		public int AdminDetalleId { get; set; }
		[ForeignKey("AdminId")]
		public int AdminId { get; set; }
		[Required(ErrorMessage = "El tipo es obligatorio")]
		public string? AdminTipos { get; set; }

		[Required(ErrorMessage = "El telefono es obligatorio")]
		[RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El formato del teléfono debe ser xxx-xxx-xxxx")]
		public string? AdminTelefono { get; set; }
	}
}

