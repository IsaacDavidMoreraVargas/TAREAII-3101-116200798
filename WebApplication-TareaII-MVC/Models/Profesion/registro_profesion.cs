using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_TareaII_MVC.Models.Profesion
{
    public partial class registro_profesion
    {
        [Key]
        public int idProfesionDisponible { get; set; }

        public string? nombreProfesion { get; set; }

        public string? gradoAcademico { get; set; }

        public int? unidadDeMedidaSalario { get; set; }
    }
}
