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

        public string? nombreEmpleado { get; set; }

        public string? fechaNacimientoEmpleado { get; set; }

        public int? cedulaEmpleado { get; set; }

        public string? contactoEmpleado { get; set; }

        public string? fechaIngresoEmpleado { get; set; }

        public string? edificioQuePerteneceEmpleado { get; set; }

        public int? salarioHoraEmpleado { get; set; }
    }

   
    
}
