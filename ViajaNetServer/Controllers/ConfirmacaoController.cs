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
    public class ConfirmacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
