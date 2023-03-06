using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_TareaII_MVC.Models.Grados
{
    public partial class registro_grado
    {
        [Key]
        public int idGradoAcademicoDisponible { get; set; }

        //[Required(ErrorMessage = "Introduzca Nombre del empleado")]
        //[Display(Name = "Introduzca Nombre del empleado")]
        public string? gradoAcademicoDisponible { get; set; }
    }
}
