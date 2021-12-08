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
        public ActionResult<Anotacao> Get(int UsuarioID)
        {
            string checklist = null;
            return Ok(checklist);
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
                usuarioRepository.PutEventos(data);
                return Ok("Ok");

            }
            catch (Exception ex)
            {
                return BadRequest("Erro");
            }
        }
    }
}
