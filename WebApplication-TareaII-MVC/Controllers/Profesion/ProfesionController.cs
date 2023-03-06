using Microsoft.AspNetCore.Mvc;
using WebApplication_TareaII_MVC.Controllers.Grados;

namespace WebApplication_TareaII_MVC.Controllers.Profesion
{
    public class ProfesionController : Controller
    {
        [BindProperty]
        public Models.Profesion.registro_profesion Registro_save { get; set; }
        [BindProperty]
        public Models.Grados.registro_grado Registro_grado { get; set; }
        public ActionResult Index()
        {
            Grado_Context gradoContexto = new Grado_Context();
            ViewBag.opciones_grados = gradoContexto.Registros_Grados.ToList();

            Profesion_Context profesionContexto = new Profesion_Context();
            ViewBag.registro_profesiones = profesionContexto.Registros_Profesiones.ToList();
            return View();

            //ViewBag.registro_profesiones
        }

        public IActionResult Registrar()
        {
            Profesion_Context profesionContexto = new Profesion_Context();
            Grado_Context gradoContexto = new Grado_Context();
            ViewBag.opciones_grados = gradoContexto.Registros_Grados.ToList();

            var found = profesionContexto.Registros_Profesiones.Find(Registro_save.idProfesionDisponible);
            if (found != null)
            {
                profesionContexto.Registros_Profesiones.Remove(found);
            }
            profesionContexto.Registros_Profesiones.Add(Registro_save);
            profesionContexto.SaveChanges();
            return RedirectToAction("Index", "Profesion");
        }

        public IActionResult Editar(int id)
        {

            Profesion_Context profesionContexto = new Profesion_Context();
            var data = profesionContexto.Registros_Profesiones.Find(id);
            if (data != null)
            {
                TempData["idProfesionDisponible"] = data.idProfesionDisponible;
                TempData["nombreProfesion"] = data.nombreProfesion;
                TempData["gradoAcademico"] = data.gradoAcademico;
                TempData["unidadDeMedidaSalario"] = data.unidadDeMedidaSalario;

                //Grado_Context gradoContexto = new Grado_Context();
                //ViewBag.opciones_grados = gradoContexto.Registros_Grados.ToList();
            }
            return RedirectToAction("Index", "Profesion");
        }

        public IActionResult Eliminar(int id)
        {
            Profesion_Context profesionContexto = new Profesion_Context();
            var found = profesionContexto.Registros_Profesiones.Find(id);
            if (found != null)
            {
                profesionContexto.Registros_Profesiones.Remove(found);
                profesionContexto.SaveChanges();
            }
            return RedirectToAction("Index", "Profesion");
        }
    }
}
