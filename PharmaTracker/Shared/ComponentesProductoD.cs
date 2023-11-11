using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
	public class ComponentesProductoD
	{
		[Key]
		public int ComponentesProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public int ProductoId { get; set; }
		[Required]
		public string? Descripción { get; set; }
	}
}
