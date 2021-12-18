using ApiWeb.Models;
using ApiWeb.Repository;
using Microsoft.AspNetCore.Cors;
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

    public class UsuarioController : ControllerBase
    {
        //private Configurations _configurations;

        //public UsuarioController(Configurations configurations)
        //{
        //    _configurations = configurations;

        //}

        //[HttpGet("Login/{Email}/{Senha}")]
        //public ActionResult<Usuario> Login(string Email, string Senha)
        //{
        //    UsuarioRepository usuarioRepository = new UsuarioRepository();
        //    var user = usuarioRepository.Login(Email, Senha);
        //    return Ok(user);
        //}

        [HttpPost("Login")]
        public ActionResult<Usuario> Login([FromBody] Usuario data)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            var user = usuarioRepository.Login(data.Email, data.Senha);
            return Ok(user);
        }

        [HttpGet("{ID}")]
        public ActionResult<Usuario> Get(string ID)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            var user =  usuarioRepository.GetUser(ID);
            return Ok(user);
        }

        [HttpGet("teste")]
        public ActionResult<Usuario> teste()
        {
           
            return Ok("OK");
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Usuario data)
        {
            try{
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                usuarioRepository.PostUser(data);
                return Ok("Ok");

            }
            catch (Exception ex)
            {
                return BadRequest("Erro");
            }
        }

        [HttpPut]
        public ActionResult<string> Put([FromBody] Usuario data)
        {

            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                usuarioRepository.PutUser(data);
                return Ok("Ok");

            }
            catch (Exception ex)
            {
                return BadRequest("Erro");
            } 

        }
    }
}
