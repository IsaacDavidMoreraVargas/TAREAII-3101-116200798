using Microsoft.AspNetCore.Mvc;

namespace WebApplication_TareaII_MVC.Controllers.Compartido
{
    public class Compartido_Context
    {
        public WebApplication_TareaII_MVC.Models.Profesion.registro_profesion Registro_save { get; set; }
        public WebApplication_TareaII_MVC.Models.Grados.registro_grado Registro_grado { get; set; }
    }
}
