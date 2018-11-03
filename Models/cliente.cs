using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class cliente
    {
        [Key]
        public int RUC {get; set;}
        [Required]
        public double empresa {get; set;}
        [Required]
        public double direccionfiscal {get; set;}
    }
}