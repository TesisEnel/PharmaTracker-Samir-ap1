using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class VendedorTiposTelefonos
    {
        [Key]
        public int VendedorTipoId { get; set; }
        public string VendedorDescripcion { get; set; }
    }
}
