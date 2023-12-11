using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTracker.Shared
{
    public class TarjetaPago
    {
        [Key]
        public int TarjetaPagoId { get; set; }
        [Required(ErrorMessage = "El titular es obligatorio")]
        public string? Titular { get; set; }

        [Required(ErrorMessage = "El número de tarjeta es obligatorio")]
        [RegularExpression(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9]{2})[0-9]{12})$", ErrorMessage = "Número de tarjeta no válido")]
        public string? NumeroTarjeta { get; set; }

        [Required(ErrorMessage = "La fecha de expiración es obligatoria")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/[0-9]{2}$", ErrorMessage = "Fecha de expiración no válida (MM/YY)")]
        public string? FechaExpiracion { get; set; }

        [Required(ErrorMessage = "El CVV es obligatorio")]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "CVV no válido")]
        public string? CVV { get; set; }
    }
}

// 		[RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El formato del teléfono debe ser xxx-xxx-xxxx")]