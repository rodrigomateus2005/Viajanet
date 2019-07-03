using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViajaNet.Common;
using ViajaNet.Models;

namespace ViajaNet.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            Order order = new Order();

            List<Produto> carrinhoAtual = HttpContext.Session.GetObjectFromJson<List<Produto>>("carrinhoAtual");

            order.Produtos = carrinhoAtual.ToArray();

            return View(order);
        }


    }
}
