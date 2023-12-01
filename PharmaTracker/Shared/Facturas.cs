using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaTracker.Shared
{
	public class Facturas
	{
		[Key]
		public int FacturaId { get; set; }
		[Required(ErrorMessage = "El tipo de factura es obligatorio")]
		public string? TipoFactura { get; set; }
		[Required(ErrorMessage = "El NCF es obligatorio")]
		public int NCF { get; set; }
		[Required(ErrorMessage = "La fecha es obligatorio")]
		public DateTime Fecha { get; set; }
		[ForeignKey("ClienteId")]
		public int ClienteId { get; set; }
		[Required]
		public List<Productos>? ListaProductos { get; set; }

		[Required(ErrorMessage ="El descuento es requerido (Si no tiene es 0.00)")]
		public decimal Descuento { get; set; }
		[Required(ErrorMessage = "El total es obligatorio")]
		public decimal Total { get; set; }
	}
}
