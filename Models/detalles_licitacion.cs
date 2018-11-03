using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class detalles_licitacion
    {
        [Key]
        public int item {get; set;}
        [Required (ErrorMessage = "Ingresar cantidad")]
        public int cantidad {get; set;}
        [Required (ErrorMessage = "Ingresar caracteristica")]
        public string caracteristica {get; set;}
        [Required (ErrorMessage = "Ingresar garantia")]
        public int garantia {get; set;}
        [Required]
        public licitacion licitacion {get; set;}
        [Required]
        public piezas piezas {get; set;}
        [Required]
        public marca marca {get; set;}
    }
}