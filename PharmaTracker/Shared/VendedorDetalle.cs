using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class VendedorDetalle
    {
        [Key]
        public int VendedorDetalleId { get; set; }
        public int VendedorId { get; set; }
        public int VendedorTipoId { get; set; }
        public string VendedorTelefono { get; set; }
    }
}
