using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;
using WebApplication_TareaII_MVC.Controllers.Edificio;

namespace WebApplication_TareaII_MVC.Controllers.Empleado
{
    public class EmpleadoController : Controller
    {
        // GET: Agregar_epleados
        
        public ActionResult Index()
        {
            Empleado_Context employeeContext= new Empleado_Context();
            ViewBag.registro_empleados = employeeContext.Registros_Empleados.ToList();
            Edificio_Context edificioContext = new Edificio_Context();
            ViewBag.opciones_edificios = edificioContext.Registros_Edificios.ToList();
            return View();
        }

        [BindProperty]
        public Models.Empleado.registro_empleados Registro_save { get; set; }
        public IActionResult Registrar()
        {
            Empleado_Context employeeContext = new Empleado_Context();
            Registro_save.fechaNacimientoEmpleado = Registro_save.fechaNacimientoEmpleado.Replace(" ","");
            Registro_save.fechaIngresoEmpleado= Registro_save.fechaIngresoEmpleado.Replace(" ", "");
            var found = employeeContext.Registros_Empleados.Find(Registro_save.idEmpleado);   
            if (found != null)
            {
                employeeContext.Registros_Empleados.Remove(found);
            }
            employeeContext.Registros_Empleados.Add(Registro_save);
            employeeContext.SaveChanges();
           
            return RedirectToAction("Index", "Empleado");
        }

        public IActionResult Editar(int id)
        {
            Empleado_Context employeeContext = new Empleado_Context();
            var data = employeeContext.Registros_Empleados.Find(id);
            if (data != null)
            {
                @TempData["idEmpleado"] = data.idEmpleado;
                @TempData["nombreEmpleado"] = data.nombreEmpleado;
                @TempData["fechaNacimientoEmpleado"] = data.fechaNacimientoEmpleado + " ";
                @TempData["cedulaEmpleado"] = data.cedulaEmpleado;
                @TempData["contactoEmpleado"] = data.contactoEmpleado;
                @TempData["fechaIngresoEmpleado"] = data.fechaIngresoEmpleado+" ";
                @TempData["edificioQuePerteneceEmpleado"] = data.edificioQuePerteneceEmpleado;
                @TempData["salarioHoraEmpleado"] = data.salarioHoraEmpleado;
            }
            return RedirectToAction("Index", "Empleado");
        }

        public IActionResult Eliminar(int id)
        {
            Empleado_Context employeeContext = new Empleado_Context();
            var found = employeeContext.Registros_Empleados.Find(id);
            if (found != null)
            {
                employeeContext.Registros_Empleados.Remove(found);
                employeeContext.SaveChanges();
            }
            return RedirectToAction("Index", "Empleado");
        }
    }
}
