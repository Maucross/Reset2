using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reset.Models
{
    public class licitacion
    {
        [Key]
        public int NumLicitacion {get; set;}
        [Required (ErrorMessage = "Ingresar fecha de creacion")]
        public DateTime fechacreacion {get; set;}
        public DateTime? fechaentrega {get; set;}
        [Required]
        public char estado {get; set;}
        [Required]
        public cliente cliente {get; set;}
        [Required]
        public usuario usuario {get; set;}
    }
}