using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimeraApi.Controllers
{
    public class Modelo
    {
        public int a { get; set; }
        public int b { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        [HttpGet]
        public int Addition (int a, int b)
        {
            return (a + b);
        }
        [HttpPost]
        public int Suma([FromBody] Modelo numeros  )
        {
            return (numeros.a + numeros.b);

        }
    }
}
