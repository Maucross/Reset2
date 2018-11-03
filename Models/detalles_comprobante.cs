using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class detalles_comprobante
    {
        [Key]
        public int item {get; set;}
        [Required]
        public int cantidad {get; set;}
        [Required]
        public string caracteristica{get; set;}
        [Required]
        public int garantia {get; set;}
        [Required]
        public decimal precio_uni{get; set;}
        [Required]
        public decimal precio_total{get; set;}
        [Required]
        public comprobante comprobante {get; set;}
        [Required]
        public marca marca {get; set;}
        [Required]
        public piezas piezas {get; set;}
        

    }
}