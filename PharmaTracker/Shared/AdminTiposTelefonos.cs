using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class AdminTiposTelefonos
    {
        [Key]
        public int AdminTipoId { get; set; }
        public string AdminDescripcion { get; set; }
    }
}
