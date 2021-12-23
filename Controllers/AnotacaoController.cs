using ApiWeb.Models;
using ApiWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacaoController : Controller
    {
        //private Configurations _configurations;

        //public AnotacaoController(Configurations configurations)
        //{
        //    _configurations = configurations;

        //}

        [HttpGet("{UsuarioID}")]
        public ActionResult<Anotacao> Get(string UsuarioID)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            var anotacoes = usuarioRepository.GetAnotacao(UsuarioID);
            var Agrupar = from p in anotacoes group p by p.Data.ToShortDateString() into g select new { data = g.Key, peso = g.Average(x => x.Peso), tempoSegundos = g.Average( x => TimeSpan.Parse(x.Tempo).TotalSeconds) };

            return Ok(Agrupar);
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Anotacao data)
        {
            var result = 0;
            if (result < 0)
            {
                return BadRequest("Erro");
            }
            return Ok("Ok");
        }

        [HttpPut]
        public ActionResult<string> Put([FromBody] Usuario data)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                usuarioRepository.PutAnotacao(data);
                return Ok("Ok");

            }
            catch (Exception ex)
            {
                return BadRequest("Erro");
            }
        }
    }
}
