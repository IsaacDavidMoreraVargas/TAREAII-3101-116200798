using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_TareaII_MVC.Models.Profesion
{
    public partial class registro_profesion
    {
        [Key]
        public int idProfesionDisponible { get; set; }

        //[Required(ErrorMessage = "Introduzca Nombre del empleado")]
        //[Display(Name = "Introduzca Nombre del empleado")]
        public string? nombreProfesion { get; set; }

        //[Required(ErrorMessage = "Introduzca Fecha nacimiento del empleado")]
        //[Display(Name = "Introduzca Fecha nacimiento del empleado")]
        public string? gradoAcademico { get; set; }
        //[Required(ErrorMessage = "Introduzca salario por hora del empleado")]
        //[Display(Name = "Introduzca salario por hora del empleado")
        public int? unidadDeMedidaSalario { get; set; }
    }
}
