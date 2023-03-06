using Microsoft.AspNetCore.Mvc;
using WebApplication_TareaII_MVC.Controllers.Edificio;
using WebApplication_TareaII_MVC.Controllers.Empleado;
using WebApplication_TareaII_MVC.Controllers.Profesion;

namespace WebApplication_TareaII_MVC.Controllers.Asociar
{
    public class AsociarController : Controller
    {
        [BindProperty]

        public Models.Asociar.asociar_registro Registro_save { get; set; }
        // GET: EdificioController
        public ActionResult Index()
        {
            Asociar_Context asociarContext = new Asociar_Context();
            Empleado_Context employeeContext = new Empleado_Context();
            Profesion_Context profesionContext = new Profesion_Context();
            ViewBag.registro_empleados = employeeContext.Registros_Empleados.ToList();
            ViewBag.registro_puestos = profesionContext.Registros_Profesiones.ToList();
            if (TempData["fechaRegistro"] == null)
            {
                    TempData["fechaRegistro"] = DateTime.Now.ToString("yyyy-MM-dd");
                    TempData["fechaRegistro1"] = DateTime.Now.ToString("yyyy-MM-dd");
            }
            ViewBag.registro_empleados_extent = employeeContext.Registros_Empleados.ToList();
            ViewBag.registro_profesion_extent= profesionContext.Registros_Profesiones.ToList();
            ViewBag.registro_registro_extent = asociarContext.Registros_registros.ToList();
            return View();
        }
        public IActionResult Registrar()
        {
            Registro_save.fechaRegistro = Registro_save.fechaRegistro.Replace(" ","");
            Asociar_Context asociarContext = new Asociar_Context();
            var found = asociarContext.Registros_registros.Find((int)Registro_save.idRegistro);
            if (found != null)
            {
                Console.WriteLine(found.fechaRegistro+"-"+Registro_save.fechaRegistro);
                if (found.idRegistro == Registro_save.idRegistro && found.idPuestoAsociado == Registro_save.idPuestoAsociado && found.fechaRegistro == Registro_save.fechaRegistro)
                {
                    //do nothing
                    //Console.WriteLine("equel");
                }
                else if (found.idRegistro == Registro_save.idRegistro && found.idPuestoAsociado != Registro_save.idPuestoAsociado && found.fechaRegistro != Registro_save.fechaRegistro)
                {
                    asociarContext.Registros_registros.Remove(found);
                    //Console.WriteLine("equel2");
                    asociarContext.Registros_registros.Add(Registro_save);
                    asociarContext.SaveChanges();
                }
                else
                {
                    //Console.WriteLine("equel3");
                    // asociarContext.Registros_registros.Remove(found);
                    //asociarContext.Registros_registros.Add(Registro_save);
                    // asociarContext.SaveChanges();
                }
            }
            else
            {
                //var found2 = asociarContext.Registros_registros.Find((int)Registro_save.idEmpleadoAsociado);
                var found2 = asociarContext.Registros_registros.ToList();
                if (found2 != null)
                {
                    var flag = false;
                    foreach (WebApplication_TareaII_MVC.Models.Asociar.asociar_registro Grupo in found2)
                    {

                        if (Grupo.idPuestoAsociado == Registro_save.idPuestoAsociado && Grupo.fechaRegistro == Registro_save.fechaRegistro)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        //do nothing
                        Console.WriteLine("equel3");
                    }
                    else
                    {
                        asociarContext.Registros_registros.Add(Registro_save);
                        asociarContext.SaveChanges();
                        Console.WriteLine("equel4");
                    }
                    /*
                    if (found2.idRegistro == Registro_save.idRegistro && found2.idPuestoAsociado == Registro_save.idPuestoAsociado && found2.fechaRegistro == Registro_save.fechaRegistro)
                    {
                        Console.WriteLine("equel");
                    }
                    else if (found2.idRegistro == Registro_save.idRegistro && found2.idPuestoAsociado == Registro_save.idPuestoAsociado && found2.fechaRegistro != Registro_save.fechaRegistro)
                    {
                        Console.WriteLine("equel2");
                        asociarContext.Registros_registros.Add(Registro_save);
                        asociarContext.SaveChanges();
                    }
                    */
                }
                else
                {
                    asociarContext.Registros_registros.Add(Registro_save);
                    asociarContext.SaveChanges();
                }
                
            }
            return RedirectToAction("Index", "Asociar");
        }

        
        public IActionResult Editar(int id)
        {
            Asociar_Context asociarContext = new Asociar_Context();
            Empleado_Context employeeContext = new Empleado_Context();
            Profesion_Context profesionContext = new Profesion_Context();

            var data = asociarContext.Registros_registros.Find(id);
            if (data != null)
            {
                @TempData["idRegistro"] = data.idRegistro;

                var data1 = employeeContext.Registros_Empleados.Find(data.idEmpleadoAsociado);
                if (data1 != null)
                {
                    @TempData["nombre_idEmpleadoAsociado"] = data1.nombreEmpleado;
                    @TempData["idEmpleadoAsociado"] = data1.idEmpleado;
                }
                var data2 = profesionContext.Registros_Profesiones.Find(data.idPuestoAsociado);
                if (data2 != null)
                {

                    @TempData["nombre_idPuestoAsociado"] = data2.nombreProfesion;
                    @TempData["idPuestoAsociado"] = data2.idProfesionDisponible;
                    TempData["nombre_idgradoAsociado"] = data2.gradoAcademico;
                }
                @TempData["fechaRegistro"] = data.fechaRegistro+" ";
                @TempData["fechaRegistro1"] = data.fechaRegistro;
            }
            return RedirectToAction("Index", "Asociar");
        }

        public IActionResult Eliminar(int id)
        {
            Asociar_Context asociarContext = new Asociar_Context();
            var found = asociarContext.Registros_registros.Find(id);
            if (found != null)
            {
                asociarContext.Registros_registros.Remove(found);
                asociarContext.SaveChanges();
            }
            return RedirectToAction("Index", "Asociar");
        }
            
    }
}
