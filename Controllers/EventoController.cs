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
    public class EventoController : Controller
    {
        //private Configurations _configurations;

        //public EventoController(Configurations configurations)
        //{
        //    _configurations = configurations;

        //}

        [HttpGet("{UsuarioID}")]
        public ActionResult<List<Evento>> Get(int UsuarioID)
        {
            string checklist = null;
            return Ok(checklist);
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Evento data)
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

        [HttpDelete("{ID}")]
        public ActionResult<string> Delete(int ID)
        {
            var result = 0;
            if (result < 0)
            {
                return BadRequest("Erro");
            }
            return Ok("Ok");
        }
    }
}
