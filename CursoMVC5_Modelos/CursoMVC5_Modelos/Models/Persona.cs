using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC5_Modelos.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo {0} es Obligatorio ...")]
        public string Nombre { get; set; }
        [StringLength(6, MinimumLength = 5, ErrorMessage = "El campo {0} debe tener una longitud minima de {2} y una longitud máxima de {1}")]
        public string CodigoPostal { get; set; }
    }
}