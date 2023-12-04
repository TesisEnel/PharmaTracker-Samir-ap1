using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaTracker.Shared
{
    public class ArticulosEnCarrito
    {
        [Key]
        public int? ProductoId { get; set; }
        public string? NombreProducto { get; set; }
        public int? Precio { get; set; }
        public string? Imagen { get; set; }
        public int? Cantidad { get; set; }
    }
}
