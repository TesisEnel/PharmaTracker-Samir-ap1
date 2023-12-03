using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PharmaTracker.Shared
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string? NombreProducto { get; set; }
		[Required(ErrorMessage = "El precio es obligatorio")]
		public int? Precio { get; set; }

		[Required(ErrorMessage = "La exitencia es obligatorio")]
        public int? Existencia { get; set; }

        [Required(ErrorMessage = "La unidad es obligatorio")]
        public string? Unidad { get; set; }
        [Required(ErrorMessage = "La categoría es obligatorio")]
        public string? Categoria { get; set; }
        
        public ICollection<DetalleLaboratorioProducto>? detalleLabProducto { get; set; }
        public ICollection<CarritoCompra>? carritoCompra { get; set; }
	}
}
