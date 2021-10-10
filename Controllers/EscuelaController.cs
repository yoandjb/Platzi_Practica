using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platzi_Practica.Models;

namespace Platzi_Practica.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var Escuela = new Escuela();
            Escuela.AñoDeCreación = 2005;
            Escuela.UniqueId = Guid.NewGuid().ToString();
            Escuela.Nombre = "platzi School";
            Escuela.Dirección = "Santo Domingo Este # 48";
            Escuela.Pais = "Republica Domincana";
            Escuela.Ciudad = "Ensanche la Fe";
            Escuela.TipoEscuela = TiposEscuela.Secundaria;
            
            ViewBag.Probando = "mensaje desde view bag";
            return View(Escuela);
        }
    }
}
