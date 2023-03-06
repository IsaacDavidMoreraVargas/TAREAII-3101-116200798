using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_TareaII_MVC.Models.Edificio
{
    public partial class registro_edificios
    {
        [Key]
        public int idEdificioDisponible { get; set; }
        public string? nombreEdificioDisponible { get; set; }
    }
}
