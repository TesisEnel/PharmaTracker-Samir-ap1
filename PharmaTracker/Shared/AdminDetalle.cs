using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class AdminDetalle
    {
        [Key]
        public int AdminDetalleId { get; set; }
        public int AdminId { get; set; }
        public int AdminTipoId { get; set; }
        public string AdminTelefono { get; set; }
    }
}
