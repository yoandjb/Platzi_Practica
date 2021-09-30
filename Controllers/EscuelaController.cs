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
            Escuela.AñoFundacion = 2005;
            Escuela.EscuelaId = Guid.NewGuid().ToString();
            Escuela.Nonbre = "platzi School";
            return View();
        }
    }
}
