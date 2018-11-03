using System;
using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class cotizacion
    {
        [Key]
        public int NumCotizacion {get; set;}
        [Required (ErrorMessage = "Ingresar fecha de creacion")]
        public DateTime fechacreacion {get; set;}
        public DateTime? fechaentrega {get; set;}
        [Required]
        public double subtotal {get; set;}
        [Required]
        public double igv {get; set;}
        [Required]
        public double montoTotal {get; set;}
        [Required (ErrorMessage = "Ingresar cliente")]
        public cliente cliente {get; set;}
        [Required ]
        public licitacion licitacion {get; set;}
        [Required]
        public usuario usuario {get; set;}
    }
}