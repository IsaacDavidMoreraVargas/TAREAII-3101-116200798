using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication_TareaII_MVC.Controllers.Empleado;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;

namespace WebApplication_TareaII_MVC.Models.Empleado
{
    public partial class registro_empleados
    {
        [Key]
        public int idEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca Nombre del empleado")]
        //[Display(Name = "Introduzca Nombre del empleado")]
        public string? nombreEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca Fecha nacimiento del empleado")]
        //[Display(Name = "Introduzca Fecha nacimiento del empleado")]
        public string? fechaNacimientoEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca cedula del empleado")]
        //[Display(Name = "Introduzca cedula del empleado")]
        public int? cedulaEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca numero contacto del empleado")]
        //[Display(Name = "Introduzca numero contacto del empleado")]
        public string? contactoEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca Fecha ingreso del empleado")]
        //[Display(Name = "Introduzca Fecha ingreso del empleado")]
        public string? fechaIngresoEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca Edificio pertenencia del empleado")]
        //[Display(Name = "Introduzca Edificio pertenencia del empleado")]
        public string? edificioQuePerteneceEmpleado { get; set; }

        //[Required(ErrorMessage = "Introduzca salario por hora del empleado")]
        //[Display(Name = "Introduzca salario por hora del empleado")]
        public int? salarioHoraEmpleado { get; set; }
    }

   
    
}
