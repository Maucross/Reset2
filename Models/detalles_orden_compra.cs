using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class detalles_orden_compra
    {
        [Key]
        public int item {get; set;}
        public int cantidad {get; set;}
        [Required]
        public string caracteristica {get; set;}
        [Required]
        public int garantia  {get; set;}
        [Required]
        public decimal precio_uni {get; set;}
        [Required]
        public decimal precio_total {get; set;}
        [Required]
        public orden_compra orden_compra {get; set;}
        [Required]
        public piezas piezas {get; set;}
        [Required]
        public marca marca {get; set;}
    }
}