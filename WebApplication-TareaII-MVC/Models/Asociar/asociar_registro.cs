using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_TareaII_MVC.Models.Asociar
{
    public partial class asociar_registro
    {

        [Key]
        public int idRegistro { get; set; }

        public int idEmpleadoAsociado { get; set; }
        public int idPuestoAsociado { get; set; }
        public string? fechaRegistro { get; set; }
    }
}
