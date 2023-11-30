using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PharmaTracker.Shared
{
	public class DetalleLaboratorioProducto
	{
		[Key]
		public int DetalleLaboratorioProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public int ProductoId { get; set; }
		[Required(ErrorMessage ="El laboratorio es obligatorio")]
		[RegularExpression(@"^[a-zA-Z\s®]+$", ErrorMessage = "Solo se permiten letras y el símbolo ®")]
		public string? Laboratorios { get; set; }
		[Required(ErrorMessage = "La cantidad es obligatorio")]
		public int Cantidad { get; set; }
    }
}
