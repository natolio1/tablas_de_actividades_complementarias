using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace actividades_complementaria.Models
{
    public class carrera
    {
        [Key]
        public int idcarrera { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String Carrera { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String reticula { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String nivel_escolar { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String clave_oficial { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String nombre_carrera { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String nombre_reducido { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int carga_maxima { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int creditos_totales { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String nivel { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String modalidad { get; set; }

    }
}
