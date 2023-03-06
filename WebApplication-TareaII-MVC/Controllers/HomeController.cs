using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_TareaII_MVC.Controllers.Empleado;
using WebApplication_TareaII_MVC.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApplication_TareaII_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Empleado_Context employeeContext = new Empleado_Context();
            ViewBag.registro_empleados = employeeContext.Registros_Empleados.ToList();
            //Console.WriteLine("------"+data.ToList());
             //data;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}