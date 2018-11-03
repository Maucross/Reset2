using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Reset.Models

{
    public class orden_compra
    {
        [Key]
        public int numOrden {get; set;}
        public DateTime? fechaentrega {get; set;}
        [Required]
        public char estado {get; set;}
        [Required]
        public decimal subtotal {get; set;}
        [Required]
        public decimal igv {get; set;}
        [Required]
        public decimal montoTotal {get; set;}
        [Required]
        public cotizacion cotizacion {get; set;}
        [Required]
        public cliente cliente {get; set;}
        [Required]
        public usuario usuario {get; set;}
    }
}