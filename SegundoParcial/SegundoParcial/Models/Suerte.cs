using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Suerte
    {
        [Key]
        public int SuerteId { get; set; }
        [Required(ErrorMessage ="El detalle es requerido")]
        [Display(Name ="Detalle de la suerte")]
        public string Detalle { get; set; }
        [Required]
        [Url]
        [Display(Name ="Enlace a imagen de la suerte")]
        public string Imagen { get; set; }
    }
}
