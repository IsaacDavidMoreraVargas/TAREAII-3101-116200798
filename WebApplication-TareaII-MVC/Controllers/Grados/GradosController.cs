using Microsoft.AspNetCore.Mvc;
using WebApplication_TareaII_MVC.Controllers.Grados;

namespace WebApplication_TareaII_MVC.Controllers.Grados
{
    public class GradosController : Controller
    {
        public ActionResult Index()
        {
            Grado_Context gradoContext = new Grado_Context();
            ViewBag.registro_grados = gradoContext.Registros_Grados.ToList();
            return View();
        }

        [BindProperty]
        public Models.Grados.registro_grado Registro_save { get; set; }
        public IActionResult Registrar()
        {
            Grado_Context gradoContext = new Grado_Context();
            var found = gradoContext.Registros_Grados.Find(Registro_save.idGradoAcademicoDisponible);
            if (found != null)
            {
                gradoContext.Registros_Grados.Remove(found);
            }
            gradoContext.Registros_Grados.Add(Registro_save);
            gradoContext.SaveChanges();
            return RedirectToAction("Index", "Grados");
        }

        public IActionResult Editar(int id)
        {

            Grado_Context gradoContext = new Grado_Context();
            var data = gradoContext.Registros_Grados.Find(id);
            if (data != null)
            {
                @TempData["idGradoAcademicoDisponible"] = data.idGradoAcademicoDisponible;
                @TempData["gradoAcademicoDisponible"] = data.gradoAcademicoDisponible;
                //@TempData["unidadDeMedidaSalario"] = data.unidadDeMedidaSalario;
            }
            return RedirectToAction("Index", "Grados");
        }

        public IActionResult Eliminar(int id)
        {
            Grado_Context gradoContext = new Grado_Context();
            var found = gradoContext.Registros_Grados.Find(id);
            if (found != null)
            {
                gradoContext.Registros_Grados.Remove(found);
                gradoContext.SaveChanges();
            }
            return RedirectToAction("Index", "Grados");
        }
    }
}
