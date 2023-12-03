using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaTracker.Shared
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string? NombreProducto { get; set; }
		[Required(ErrorMessage = "El precio es obligatorio")]
		public int? Precio { get; set; }

		[Required(ErrorMessage = "La existencia es obligatoria")]
        public int? Existencia { get; set; }
		[Url(ErrorMessage = "La imagen debe introducirse como un link")]
		public string? Imagen { get; set; }

		[Required(ErrorMessage = "La unidad es obligatoria")]
        public string? Unidad { get; set; }
        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string? Categoria { get; set; }

		[ForeignKey("ProductoId")]
		public ICollection<DetalleLaboratorioProducto> detalleLabProducto { get; set; } = new List<DetalleLaboratorioProducto>();
	}	
}
