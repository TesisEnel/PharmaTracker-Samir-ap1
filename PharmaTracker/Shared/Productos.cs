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
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]   
        public int Precio { get; set; }
        [Required(ErrorMessage = "El laboratorio es obligatorio")]
        public string Laboratorio { get; set; }
        [Required(ErrorMessage = "La exitencia es obligatorio")]
        public int Existencia { get; set; }
        [Required(ErrorMessage = "La unidad es obligatorio")]
        public string Unidad { get; set; }
        public string imagen { get; set; }
	}
}
