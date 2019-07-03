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
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiRabbitMQController : ControllerBase
    {

        [Route("Enfileirar")]
        public bool Enfileirar(string ip, string nomePagina, string browser, string parametrosPagina)
        {
            return true;
        }

    }
}
