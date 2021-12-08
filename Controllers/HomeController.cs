using ApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<Object> Index()
        {
            return Ok(new { Value1 = 1, Value2 = 2 });
        }

        [HttpGet("Login")]
        public ActionResult<string> Login()
        {
            return Ok("OK");
        }
    }
}
