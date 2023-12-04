using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class ArticulosEnCarrito
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int? Precio { get; set; }
        public string Imagen { get; set; }
    }
}
