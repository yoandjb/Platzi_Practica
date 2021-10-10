using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platzi_Practica.Models;

namespace Platzi_Practica.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var Asignatura = new Asignatura
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programacion",
                
             };

                ViewBag.Fecha = DateTime.Now;
                return View(Asignatura);

        }
        
    }


}
