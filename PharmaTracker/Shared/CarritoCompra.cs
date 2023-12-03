using PharmaTracker.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class CarritoCompra
    {
		[Key]
		public int CarritoCompraId { get; set; }
		public SesionDTO? Sesion { get; set; }

		public Productos? Producto { get; set; }
		[ForeignKey("Producto")]
		public int? ProductoId { get; set; }
		[Required(ErrorMessage = "La cantidad es obligatorio")]
		public int? Cantidad { get; set; }
		[DataType(DataType.MultilineText)]
		public string? Comentario { get; set; }
		public  int? Subtotal => Producto?.Precio * Cantidad;

	}
}
