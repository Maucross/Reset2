using System;
using System.ComponentModel.DataAnnotations;
namespace Reset.Models
{
    public class comprobante
    {
        [Key]
        public int NumComprobante {get; set;}
        [Required]
        public DateTime fechacotizacion {get; set;}
        [Required]
        public string TipoComprobante {get; set;}
        [Required]
        public DateTime fechafact {get; set;}
       
        public DateTime? fechaentrega {get; set;}
        [Required]
        public string estado {get; set;}
        [Required]
        public double subtotal {get; set;}
        [Required]
        public double igv {get; set;}
        [Required]
        public double montoTotal {get;set;}
        [Required]
        public cliente cliente {get; set;}
        [Required]
        public cotizacion cotizacion {get; set;}
        [Required]
        public usuario usuario {get; set;}
    }
}