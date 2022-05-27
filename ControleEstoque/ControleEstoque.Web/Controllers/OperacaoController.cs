using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        public IActionResult EntradaEstoque()
        {
            return View();
        }
        public IActionResult SaidaEstoque()
        {
            return View();
        }
        public IActionResult LancPerdaProduto()
        {
            return View();
        }
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
