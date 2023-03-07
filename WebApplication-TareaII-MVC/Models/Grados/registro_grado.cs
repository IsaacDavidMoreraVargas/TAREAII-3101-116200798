using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_TareaII_MVC.Models.Grados
{
    public partial class registro_grado
    {
        [Key]
        public int idGradoAcademicoDisponible { get; set; }

        public string? gradoAcademicoDisponible { get; set; }
    }
}
