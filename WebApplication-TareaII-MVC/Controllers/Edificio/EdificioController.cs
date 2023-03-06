using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_TareaII_MVC.Controllers.Empleado;

namespace WebApplication_TareaII_MVC.Controllers.Edificio
{
    public class EdificioController : Controller
    {
        [BindProperty]
        public Models.Edificio.registro_edificios Edificio_save { get; set; }
        // GET: EdificioController
        public ActionResult Index()
        {
            Edificio_Context edificioContext = new Edificio_Context();
            ViewBag.registro_edificios = edificioContext.Registros_Edificios.ToList();
            return View();
        }
        public IActionResult Registrar()
        {
            Edificio_Context edificioContext = new Edificio_Context();
            var number = edificioContext.Registros_Edificios.ToList();
            var found = edificioContext.Registros_Edificios.Find((int)Edificio_save.idEdificioDisponible);
            if (found != null)
            {
                edificioContext.Registros_Edificios.Remove(found);
                edificioContext.Registros_Edificios.Add(Edificio_save);
            }
            else if (number.Count < 3)
            {
                edificioContext.Registros_Edificios.Add(Edificio_save);
            }
                
            edificioContext.SaveChanges();
            return RedirectToAction("Index", "Edificio");
        }
        public IActionResult Editar(int id)
        {
            Edificio_Context edificioContext = new Edificio_Context();
            var data = edificioContext.Registros_Edificios.Find(id);
            if (data != null)
            {
                @TempData["Nombre_Edificio"] = data.nombreEdificioDisponible;
                @TempData["key_Edificio"] = id;
            }
            return RedirectToAction("Index", "Edificio");
        }

        public IActionResult Eliminar(int id)
        {
            Edificio_Context edificioContext = new Edificio_Context();
            var found = edificioContext.Registros_Edificios.Find(id);
            if (found != null)
            {
                edificioContext.Registros_Edificios.Remove(found);
                edificioContext.SaveChanges();
            }
            return RedirectToAction("Index", "Edificio");
        }  
    }
}
