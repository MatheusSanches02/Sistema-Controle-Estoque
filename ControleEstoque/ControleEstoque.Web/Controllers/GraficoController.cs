using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
        public IActionResult PerdaMes()
        {
            return View();
        }
    }
}
