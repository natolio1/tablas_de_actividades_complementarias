using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace actividades_complementaria.Models
{
    public class Organigrama
    {
        [Key]
        public int idorganigrama { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String area { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int descripcion { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int area_depende { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int nivel { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public int tipo_area { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ingrese un nombre de minimo 3 caracteristicas a 50 como minimo")]
        public String titular { get; set; }
        

    }
}
