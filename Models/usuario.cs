using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class usuario
    {
        [Key]
        public int DNI {get; set;}
        [Required]
        public int nombre {get; set;}
        [Required]
        public string apepat {get; set;}
        [Required]
        public int apemat {get; set;}
    }
}