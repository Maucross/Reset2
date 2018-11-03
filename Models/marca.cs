using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class marca
    {
        [Key]
        public int IDMarca  {get; set;}
        [Required]
        public string  marcad {get; set;}
    }
}