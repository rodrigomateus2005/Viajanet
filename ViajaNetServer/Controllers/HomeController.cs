using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViajaNet.Models;
using Microsoft.AspNetCore.Http;
using ViajaNet.Common;

namespace ViajaNet.Controllers
{
    public class HomeController : Controller
    {
        private static Produto[] Produtos = new Produto[] {
                new Produto {
                    Id = 1
                    , Nome = "Guarujá"
                    , Preco = 500
                },
                new Produto {
                    Id = 2
                    , Nome= "Ubatuba"
                    , Preco = 650
                },
                new Produto {
                    Id = 3
                    , Nome= "Rio de Janeiro"
                    , Preco = 950.50m
                },
                new Produto {
                    Id = 4
                    , Nome = "Maragogi"
                    , Preco = 2500
                    , PrecoPromocao = 1999.99m
                }
            };

        public IActionResult Index()
        {
            return View(HomeController.Produtos.Where(x => x.PrecoPromocao == 0).ToArray());
        }

        public IActionResult Landing()
        {
            return View(HomeController.Produtos.Where(x => x.PrecoPromocao > 0).ToArray());
        }

        public IActionResult Viajar(int idProdutoViajar)
        {

            List<Produto> carrinhoAtual = HttpContext.Session.GetObjectFromJson<List<Produto>>("carrinhoAtual");

            if (carrinhoAtual == null)
            {
                carrinhoAtual = new List<Produto>();
            }

            if (!carrinhoAtual.Any(x => x.Id == idProdutoViajar))
            {
                var produto = HomeController.Produtos.FirstOrDefault(x => x.Id == idProdutoViajar);

                if (produto != null) {
                    carrinhoAtual.Add(produto);
                }
            }

            HttpContext.Session.SetObjectAsJson("carrinhoAtual", carrinhoAtual);

            return RedirectToAction("Index", "Carrinho");
        }

    }
}
