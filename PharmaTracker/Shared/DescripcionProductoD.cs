using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaTracker.Shared
{
    public class DescripcionProductoD
    {
        [Key]
        public int DetalleProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }

    }
}
