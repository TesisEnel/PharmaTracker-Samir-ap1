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
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public string Laboratorio { get; set; }
        public int Existencia { get; set; }

        public ICollection<DescripcionProductoD> DetalleProducto { get; set; }
    }
}
